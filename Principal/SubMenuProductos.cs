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
    public partial class SubMenuProductos : Form
    {
        public SubMenuProductos()
        {
            InitializeComponent();
        }

        private void btSubMenuRegistrarProducto_Click(object sender, EventArgs e)
        {
            Producto menu = new Producto();
            menu.Show();
            this.Hide();
        }

        private void btSubMenuActualizarProducto_Click(object sender, EventArgs e)
        {
            ActualizarProducto menu = new ActualizarProducto();
            menu.Show();
            this.Hide();
        }

        private void btSubMenuConsultarProducto_Click(object sender, EventArgs e)
        {
            ConsultarProducto menu = new ConsultarProducto();
            menu.Show();
            this.Hide();
        }

        private void btSubMenuEliminarProducto_Click(object sender, EventArgs e)
        {
            EliminarProducto menu = new EliminarProducto();
            menu.Show();
            this.Hide();
        }




        private void lbTituloSubMenuProductos_Click(object sender, EventArgs e)
        {

        }

        private void btVolver_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }
    }
}
