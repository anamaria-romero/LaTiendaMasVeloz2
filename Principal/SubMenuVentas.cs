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
    public partial class SubMenuVentas : Form
    {
        public SubMenuVentas()
        {
            InitializeComponent();
        }

        private void btSubMenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            Fecha menu = new Fecha();
            menu.Show();
            this.Hide();
        }

        private void btSubMenuConsultarVenta_Click(object sender, EventArgs e)
        {
            ConsultarFactura menu = new ConsultarFactura();
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
