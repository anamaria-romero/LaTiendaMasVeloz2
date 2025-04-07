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
    public partial class SubMenuProveedores : Form
    {
        public SubMenuProveedores()
        {
            InitializeComponent();
        }

        private void btSubMenuRegistrarProveedores_Click(object sender, EventArgs e)
        {
            Proveedor menu = new Proveedor();
            menu.Show();
            this.Hide();
        }

        private void btSubMenuActualizarProveedores_Click(object sender, EventArgs e)
        {
            ActualizarProveedores menu = new ActualizarProveedores();
            menu.Show();
            this.Hide();
        }

        private void btSubMenuConsultarProveedores_Click(object sender, EventArgs e)
        {
            ConsultarProveedores menu = new ConsultarProveedores();
            menu.Show();
            this.Hide();
        }

        private void btSubMenuEliminarProveedores_Click(object sender, EventArgs e)
        {
            EliminarProveedor menu = new EliminarProveedor();
            menu.Show();
            this.Hide();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }
    }
}
