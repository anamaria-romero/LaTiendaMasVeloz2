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
            int id = int.Parse(tbIdentificadorProducto.Text);
            string nombre = tbActualizarNombreProducto.Text;
            string marca = tbActualizaMarcaProducto.Text;
            int? cantidad = string.IsNullOrWhiteSpace(tbActualizaCantidadProducto.Text) ? (int?)null : int.Parse(tbActualizaCantidadProducto.Text);
            decimal? precio = string.IsNullOrWhiteSpace(tbActualizaPrecioProducto.Text) ? (decimal?)null : decimal.Parse(tbActualizaPrecioProducto.Text);
            string referencia = tbActualizarReferenciaProducto.Text;
            int? idProveedor = string.IsNullOrWhiteSpace(tbActualizarProveedor.Text) ? (int?)null : int.Parse(tbActualizarProveedor.Text);

            productoController.ActualizarProducto(id, nombre, marca, cantidad, precio, idProveedor, referencia);
            MessageBox.Show("Producto actualizado con éxito.");
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbIdentificadorProducto.Text);

            ProductoEntity producto = productoController.ObtenerProductoPorId(id);

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
    }
}
