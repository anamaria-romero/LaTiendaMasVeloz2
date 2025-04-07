using System;
using System.Windows.Forms;
using Logica;

namespace Principal
{
    public partial class EliminarUsuario : Form
    {
        private UsuarioController usuarioController = new UsuarioController();

        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void btEliminarCliente_Click(object sender, EventArgs e)
        {
            string documento = tbDocumento.Text.Trim();

            if (string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("Por favor, ingrese un documento.");
                return;
            }

            var usuario = usuarioController.ConsultarUsuario(documento);

            if (usuario == null)
            {
                MessageBox.Show("Usuario no encontrado.");
                lbUsuarioEliminado.Text = "";
                return;
            }

            string mensaje = usuarioController.EliminarUsuario(documento);
            MessageBox.Show(mensaje);

            if (mensaje.Contains("eliminado"))
            {
                lbUsuarioEliminado.Text = $"Usuario eliminado: {usuario.nombre}, Rol: {usuario.rol}";
            }
            else
            {
                lbUsuarioEliminado.Text = mensaje;
            }
        }

        private void lbUsuarioEliminado_Click(object sender, EventArgs e)
        {

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            SubMenuUsuarios menu = new SubMenuUsuarios();
            menu.Show();
            this.Hide();
        }
    }
}
