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
            SubMenuClientes subMenu = new SubMenuClientes();
            subMenu.Show();

        }

        private void btEmpleados_Click(object sender, EventArgs e)
        {
            SubMenuUsuarios subMenuUsuarios = new SubMenuUsuarios();
            subMenuUsuarios.Show();
        }

        private void btInventario_Click(object sender, EventArgs e)
        {
            SubMenuProductos subMenuProductos = new SubMenuProductos();
            subMenuProductos.Show();
        }

        private void btProveedores_Click(object sender, EventArgs e)
        {
            SubMenuProveedores subMenuProveedores = new SubMenuProveedores();
            subMenuProveedores.Show();
        }

        private void btVentas_Click(object sender, EventArgs e)
        {
            SubMenuVentas subMenuVentas = new SubMenuVentas();
            subMenuVentas.Show();
        }
    }
}
