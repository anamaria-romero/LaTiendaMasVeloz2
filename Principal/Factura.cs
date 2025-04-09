using Logica;
using Modelo.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Principal
{
    public partial class Fecha : Form
    {
        private ProductoController productoController = new ProductoController();
        private FacturaController facturaController = new FacturaController();

        private ProductoEntity productoActual;
        private List<ProductosFactura> listaProductos = new List<ProductosFactura>();
        private decimal totalPagar = 0;

        public Fecha()
        {
            InitializeComponent();

            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("nombreArticulo", "Nombre del artículo");
            dataGridView1.Columns.Add("cantidad", "Cantidad");
            dataGridView1.Columns.Add("precioUnitario", "Precio Unitario");
            dataGridView1.Columns.Add("subtotal", "Subtotal");
        }


        private void btBuscarFactura_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbIdArticulo.Text, out int idProducto))
            {
                MessageBox.Show("Ingrese un ID de producto válido.");
                return;
            }

            productoActual = productoController.ConsultarProducto(idProducto);

            if (productoActual != null)
            {
                tbCantidad.Text = "1";
                tbTotal.Text = productoActual.precio.ToString("F2");
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void btCargaralalistaFactura_Click(object sender, EventArgs e)
        {
            if (productoActual == null)
            {
                MessageBox.Show("Primero busque un producto.");
                return;
            }

            if (!int.TryParse(tbCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            decimal subtotal = cantidad * productoActual.precio;

            ProductosFactura detalle = new ProductosFactura
            {
                id_producto = productoActual.id,
                cantidad = cantidad,
                subtotal = subtotal
            };

            listaProductos.Add(detalle);

            dataGridView1.Rows.Add(
                productoActual.nombre,
                cantidad,
                productoActual.precio.ToString("F2"),
                subtotal.ToString("F2")
            );

            totalPagar += subtotal;
            lbTotalpagarFactura.Text = $"$ {totalPagar:F2}";

            tbIdArticulo.Clear();
            tbCantidad.Clear();
            tbTotal.Clear();
            productoActual = null;
        }

        private void btVenderFactura_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbIdCliente.Text, out int idCliente) || !int.TryParse(tbIdEmpleado.Text, out int idEmpleado))
            {
                MessageBox.Show("ID Cliente o Empleado inválido.");
                return;
            }

            if (!decimal.TryParse(tbEfectivoFactura.Text, out decimal efectivo))
            {
                MessageBox.Show("Ingrese un valor válido en efectivo.");
                return;
            }

            if (efectivo < totalPagar)
            {
                MessageBox.Show("El efectivo es insuficiente para realizar la compra.");
                return;
            }

            if (listaProductos.Count == 0)
            {
                MessageBox.Show("Debe agregar productos a la factura.");
                return;
            }

            FacturaEntity factura = new FacturaEntity
            {
                id_cliente = idCliente,
                id_usuario = idEmpleado,
                total = totalPagar,
                fecha = dateTimePicker1.Value
            };

            int idFactura = facturaController.CrearFactura(factura);

            foreach (var producto in listaProductos)
            {
                producto.id_factura = idFactura;
                facturaController.AgregarProductoAFactura(producto);
            }

            string nombreCliente = facturaController.ObtenerNombreCliente(idCliente);
            string nombreEmpleado = facturaController.ObtenerNombreEmpleado(idEmpleado);

            GeneradorPDF.GenerarFacturaPDF(idFactura, nombreCliente, nombreEmpleado, dataGridView1, totalPagar, efectivo);

            MessageBox.Show($"Factura #{idFactura} creada con éxito.");

            listaProductos.Clear();
            dataGridView1.Rows.Clear();
            totalPagar = 0;
            lbTotalpagarFactura.Text = "$ 0000";
            tbIdCliente.Clear();
            tbIdEmpleado.Clear();
            tbEfectivoFactura.Clear();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            SubMenuVentas menu = new SubMenuVentas();
            menu.Show();
            this.Hide();
        }
    }
}
