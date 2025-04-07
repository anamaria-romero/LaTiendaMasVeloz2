using Logica;
using Modelo.Entities;
using System;
using System.Windows.Forms;

namespace Principal
{
    public partial class Fecha : Form
    {
        private ProductoController productoController = new ProductoController();
        private ProductoEntity productoActual;

        public Fecha()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void tbIdCliente_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbIdEmpleado_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbIdArticulo_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbCantidad_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {
        }

        private void btCargaralalistaFactura_Click(object sender, EventArgs e)
        {
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
                tbCantidad.Text = productoActual.cantidad.ToString();
                tbTotal.Text = productoActual.precio.ToString("F2");
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void lbTotalpagarFactura_Click(object sender, EventArgs e)
        {
        }

        private void lbNumeroTotalFactura_Click(object sender, EventArgs e)
        {
        }

        private void tbEfectivoFactura_TextChanged(object sender, EventArgs e)
        {
        }

        private void btVenderFactura_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void lbIdCliente_Click(object sender, EventArgs e)
        {
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            SubMenuVentas menu = new SubMenuVentas();
            menu.Show();
            this.Hide();
        }
    }
}
