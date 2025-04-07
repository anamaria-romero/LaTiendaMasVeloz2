using System;
using System.Windows.Forms;
using Logica;
using Modelo.Entities; 

namespace Principal
{
    public partial class ConsultarProducto : Form
    {
        private ProductoController productoController;

        public ConsultarProducto()
        {
            InitializeComponent();
            productoController = new ProductoController();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            int id = int.TryParse(tbIdentificador.Text.Trim(), out int idVal) ? idVal : 0;

            if (id <= 0)
            {
                MessageBox.Show("Por favor, ingrese un identificador de producto válido.");
                return;
            }

            ProductoEntity producto = productoController.ConsultarProducto(id);

            if (producto != null)
            {
                lbMostrarProducto.Text = $"Nombre: {producto.nombre}\nMarca: {producto.marca}\nCantidad: {producto.cantidad}\nPrecio: {producto.precio:C}\nReferencia: {producto.referencia}";
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            SubMenuProductos menu = new SubMenuProductos();
            menu.Show();
            this.Hide();
        }
    }
}
