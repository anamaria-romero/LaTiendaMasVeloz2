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
    public partial class ConsultarFactura : Form
    {
        public ConsultarFactura()
        {
            InitializeComponent();
        }

        private void tbIdentificadorFactura_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbMostrarFactura_Click(object sender, EventArgs e)
        {

        }

        private void btConsultar_Click(object sender, EventArgs e)
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
