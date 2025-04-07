using System;
using System.Windows.Forms;
using Logica;
using Modelo.Entities;

namespace Principal
{
    public partial class ActualizarProducto : Form
    {
        private ProductoController productoController;

        public ActualizarProducto()
        {
            InitializeComponent();
            productoController = new ProductoController();
        }

        private void btActualizarProducto_Click(object sender, EventArgs e)
        {
            ProductoEntity producto = new ProductoEntity
            {
                id = int.Parse(tbIdentificadorProducto.Text),
                nombre = tbActualizarNombreProducto.Text,
                marca = tbActualizaMarcaProducto.Text,
                cantidad = string.IsNullOrWhiteSpace(tbActualizaCantidadProducto.Text) ? 0 : int.Parse(tbActualizaCantidadProducto.Text),
                precio = string.IsNullOrWhiteSpace(tbActualizaPrecioProducto.Text) ? 0 : decimal.Parse(tbActualizaPrecioProducto.Text),
                referencia = tbActualizarReferenciaProducto.Text,
                id_proveedor = string.IsNullOrWhiteSpace(tbActualizarProveedor.Text) ? (int?)null : int.Parse(tbActualizarProveedor.Text)
            };

            productoController.ActualizarProducto(producto);
            MessageBox.Show("Producto actualizado con éxito.");

            label7.Text = $"Producto actualizado: {producto.nombre}, Marca: {producto.marca},\n Cantidad: {producto.cantidad}, Precio: ${producto.precio}";
        }


        private void btBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbIdentificadorProducto.Text);

            ProductoEntity producto = productoController.ConsultarProducto(id);

            if (producto != null)
            {
                tbActualizarNombreProducto.Text = producto.nombre;
                tbActualizaMarcaProducto.Text = producto.marca;
                tbActualizaCantidadProducto.Text = producto.cantidad.ToString();
                tbActualizaPrecioProducto.Text = producto.precio.ToString();
                tbActualizarReferenciaProducto.Text = producto.referencia;
                tbActualizarProveedor.Text = producto.id_proveedor?.ToString() ?? string.Empty;
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void ActualizarProducto_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            SubMenuProductos menu = new SubMenuProductos();
            menu.Show();
            this.Hide();
        }
    }
}
