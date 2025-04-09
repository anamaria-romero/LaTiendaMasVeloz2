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
            Usuario menu = new Usuario();
            menu.Show();
            this.Hide();
        }

        private void btSubMenuActualizarUsuario_Click(object sender, EventArgs e)
        {
            ActualizarUsuario menu = new ActualizarUsuario();
            menu.Show();
            this.Hide();
        }

        private void btSubMenuConsultarUsuario_Click(object sender, EventArgs e)
        {
            ConsultarUsuario menu = new ConsultarUsuario();
            menu.Show();
            this.Hide();
        }

        private void btSubMenuEliminarUsuario_Click(object sender, EventArgs e)
        {
            EliminarUsuario menu = new EliminarUsuario();
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
