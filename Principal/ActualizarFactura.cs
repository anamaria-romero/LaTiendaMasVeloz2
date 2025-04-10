using Logica;
using Modelo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class ActualizarFactura : Form
    {

        FacturaController facturaController = new FacturaController();

        public ActualizarFactura()
        {
            InitializeComponent();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            SubMenuVentas menu = new SubMenuVentas();
            menu.Show();
            this.Hide();
        }

        private void tbIdFacturaActualizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btBuscarIdFactura_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbIdFacturaActualizar.Text, out int idFactura))
            {
                MessageBox.Show("Por favor ingrese un ID de factura válido.");
                return;
            }

            var factura = facturaController.ConsultarFacturaPorId(idFactura);
            if (factura == null)
            {
                MessageBox.Show("Factura no encontrada.");
                return;
            }

            tbIdClienteActualizar.Text = factura.id_cliente.ToString();
            tbIdEmpleadoActualizar.Text = factura.id_usuario.ToString();
            dateTimePicker1.Value = factura.fecha;
            tbTotalActualizar.Text = factura.total.ToString("F2");

            dataGridView1.Rows.Clear();

            var productos = facturaController.ConsultarProductosPorFactura(idFactura);
            foreach (var item in productos)
            {
                var producto = facturaController.ConsultarProducto(item.id_producto);
                decimal precioUnitario = item.subtotal / item.cantidad;

                dataGridView1.Rows.Add(producto.nombre, item.cantidad, precioUnitario.ToString("F2"), item.subtotal.ToString("F2"));
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbIdClienteActualizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIdEmpleadoActualizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIdArticuloActualizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCantidadProductoActualizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTotalActualizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCargaralalistaFacturaActualizar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btBuscarFacturaActualizar_Click(object sender, EventArgs e)
        {

        }

        private void lbTotalpagarFacturaActualizar_Click(object sender, EventArgs e)
        {

        }

        private void tbEfectivoFacturaActualizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btVenderFacturaActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbIdFacturaActualizar.Text, out int idFactura))
            {
                MessageBox.Show("ID de factura inválido.");
                return;
            }

            if (!int.TryParse(tbIdClienteActualizar.Text, out int idCliente) ||
                !int.TryParse(tbIdEmpleadoActualizar.Text, out int idEmpleado))
            {
                MessageBox.Show("Verifique los campos de cliente y empleado.");
                return;
            }

            if (!decimal.TryParse(tbEfectivoFacturaActualizar.Text, out decimal efectivo))
            {
                MessageBox.Show("Ingrese el efectivo correctamente.");
                return;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto.");
                return;
            }

            decimal total = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Cells["SubTotal"].Value != null)
                {
                    total += decimal.Parse(fila.Cells["SubTotal"].Value.ToString());
                }
            }

            var factura = new FacturaEntity
            {
                id = idFactura,
                id_cliente = idCliente,
                id_usuario = idEmpleado,
                total = total,
                fecha = dateTimePicker1.Value
            };

            BaseDatos db = new BaseDatos();
            db.ActualizarFactura(factura);

            db.EliminarProductosPorFactura(idFactura);

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.IsNewRow) continue;

                string nombreProducto = fila.Cells["Nombre del articulo"].Value.ToString();
                int cantidad = int.Parse(fila.Cells["Cantidad"].Value.ToString());
                decimal subtotal = decimal.Parse(fila.Cells["SubTotal"].Value.ToString());

                int idProducto = db.ObtenerIdProductoPorNombre(nombreProducto); 

                var productoFactura = new ProductosFactura
                {
                    id_factura = idFactura,
                    id_producto = idProducto,
                    cantidad = cantidad,
                    subtotal = subtotal
                };

                db.AgregarProductoAFactura(productoFactura);
            }

            MessageBox.Show("Factura actualizada correctamente.");
        }
    }
}
