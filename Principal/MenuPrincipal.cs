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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            SubMenuClientes menu = new SubMenuClientes();
            menu.Show();
            this.Hide();


        }

        private void btEmpleados_Click(object sender, EventArgs e)
        {
            SubMenuUsuarios menu = new SubMenuUsuarios();
            menu.Show();
            this.Hide();
        }

        private void btInventario_Click(object sender, EventArgs e)
        {
            SubMenuProductos menu = new SubMenuProductos();
            menu.Show();
            this.Hide();
        }

        private void btProveedores_Click(object sender, EventArgs e)
        {
            SubMenuProveedores menu = new SubMenuProveedores();
            menu.Show();
            this.Hide();
        }

        private void btVentas_Click(object sender, EventArgs e)
        {
            SubMenuVentas menu = new SubMenuVentas();
            menu.Show();
            this.Hide();
        }
    }
}
