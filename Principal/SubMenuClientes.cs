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
            Cliente frmCliente = new Cliente();
            frmCliente.Show();
        }

        private void btSubMenuActualizarCliente_Click(object sender, EventArgs e)
        {
            ActualizarClientes frmActualizar = new ActualizarClientes();
            frmActualizar.Show();
        }

        private void btSubMenuEliminarCliente_Click(object sender, EventArgs e)
        {
            EliminarClientes frmEliminar = new EliminarClientes();
            frmEliminar.Show();
        }

        private void btSubMenuConsultarCliente_Click(object sender, EventArgs e)
        {
            ConsultarClientes frmConsultar = new ConsultarClientes();
            frmConsultar.Show();
        }
    }
}
