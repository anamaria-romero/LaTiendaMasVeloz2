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
    public partial class SubMenuProductoProveedor : Form
    {
        public SubMenuProductoProveedor()
        {
            InitializeComponent();
        }

        private void btSubMenuRegistrarProductoProveedor_Click(object sender, EventArgs e)
        {
            RegistrarIngreso menu = new RegistrarIngreso();
            menu.Show();
            this.Hide();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal(); 
            menu.Show();
            this.Hide();
        }



        private void btSubMenuActualizarProductoProveedor_Click(object sender, EventArgs e)
        {
            ActualizarProductoProveedor menu = new ActualizarProductoProveedor();
            menu.Show();
            this.Hide();
        }

        private void btSubMenuConsultarProductoProveedor_Click(object sender, EventArgs e)
        {
            ConsultarProductoProveedor menu = new ConsultarProductoProveedor();
            menu.Show();
            this.Hide();
        }

        private void btSubMenuEliminarProductoProveedor_Click(object sender, EventArgs e)
        {
            EliminarProductoProveedor menu = new EliminarProductoProveedor();
            menu.Show();
            this.Hide();
        }
    }
}
