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
    public partial class SubMenuUsuarios : Form
    {
        public SubMenuUsuarios()
        {
            InitializeComponent();
        }

        private void btSubMenuRegistrarUsuario_Click(object sender, EventArgs e)
        {
            Usuario frmUsuario = new Usuario();
            frmUsuario.Show();
        }

        private void btSubMenuActualizarUsuario_Click(object sender, EventArgs e)
        {
            ActualizarUsuario frmActualizarUsuario = new ActualizarUsuario();
            frmActualizarUsuario.Show();
        }

        private void btSubMenuConsultarUsuario_Click(object sender, EventArgs e)
        {
            ConsultarUsuario frmConsultarUsuario = new ConsultarUsuario();
            frmConsultarUsuario.Show();
        }

        private void btSubMenuEliminarUsuario_Click(object sender, EventArgs e)
        {
            EliminarUsuario frmEliminarUsuario = new EliminarUsuario();
            frmEliminarUsuario.Show();
        }
    }
}
