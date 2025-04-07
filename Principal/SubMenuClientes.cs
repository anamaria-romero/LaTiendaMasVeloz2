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
    public partial class SubMenuClientes : Form
    {
        public SubMenuClientes()
        {
            InitializeComponent();
        }

        private void btSubMenuRegistrarCliente_Click(object sender, EventArgs e)
        {
            Cliente menu = new Cliente();
            menu.Show();
            this.Hide();
        }

        private void btSubMenuActualizarCliente_Click(object sender, EventArgs e)
        {
            ActualizarClientes menu = new ActualizarClientes();
            menu.Show();
            this.Hide();
        }

        private void btSubMenuEliminarCliente_Click(object sender, EventArgs e)
        {
            EliminarClientes menu = new EliminarClientes();
            menu.Show();
            this.Hide();
        }

        private void btSubMenuConsultarCliente_Click(object sender, EventArgs e)
        {
           ConsultarClientes menu = new ConsultarClientes();
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
