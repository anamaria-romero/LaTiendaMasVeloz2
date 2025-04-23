using System;
using System.Windows.Forms;
using Logica;
using Modelo.Entities;
using MySqlX.XDevAPI;

namespace Principal
{
    public partial class ConsultarUsuario : Form
    {
        private UsuarioController usuarioController = new UsuarioController();

        public ConsultarUsuario()
        {
            InitializeComponent();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            string documento = tbDocumentoUsuario.Text.Trim();
            if (string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("Por favor, ingrese un documento válido.");
                return;
            }

            UsuarioEntity usuario = usuarioController.ConsultarUsuario(documento);

            if (usuario != null)
            {
                lbMostrarUsuario.Text = $"Id: {usuario.id}\nNombre: {usuario.nombre}\nRol: {usuario.rol}\nContraseña: {usuario.contraseña}";
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            SubMenuUsuarios menu = new SubMenuUsuarios();
            menu.Show();
            this.Hide();
        }
    }
}
