using System;
using System.Data;
using System.Windows.Forms;
using Logica;

namespace Principal
{
    public partial class ActualizarUsuario : Form
    {
        private UsuarioController usuarioController = new UsuarioController();

        public ActualizarUsuario()
        {
            InitializeComponent();
        }

        private void btBuscarUsuario_Click(object sender, EventArgs e)
        {
            string documento = tbDocumento.Text.Trim();

            if (string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("Por favor, ingrese un documento.");
                return;
            }

            DataTable dt = usuarioController.ConsultarUsuario(documento);
            if (dt.Rows.Count > 0)
            {
                tbActualizarNombre.Text = dt.Rows[0]["nombre"].ToString();
                tbActualizarContraseña.Text = dt.Rows[0]["contraseña"].ToString();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            string documento = tbDocumento.Text.Trim();
            string nombre = tbActualizarNombre.Text.Trim();
            string contraseña = tbActualizarContraseña.Text.Trim();

            if (string.IsNullOrEmpty(documento) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            string mensaje = usuarioController.ActualizarUsuario(nombre, documento, contraseña);
            MessageBox.Show(mensaje);
        }
    }
}
