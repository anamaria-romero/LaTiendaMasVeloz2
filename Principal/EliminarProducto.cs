using System;
using System.Windows.Forms;
using Logica;

namespace Principal
{
    public partial class EliminarProducto : Form
    {
        private ProductoController productoController;

        public EliminarProducto()
        {
            InitializeComponent();
            productoController = new ProductoController();
        }

        private void btEliminarProducto_Click(object sender, EventArgs e)
        {
            int id = int.TryParse(tbIdentificador.Text.Trim(), out int idVal) ? idVal : 0;

            if (id <= 0)
            {
                MessageBox.Show("Por favor, ingrese un identificador de producto válido.");
                return;
            }

            try
            {
                productoController.EliminarProducto(id);
                MessageBox.Show("Producto eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
        }
    }
}
