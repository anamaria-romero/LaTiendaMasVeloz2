using System;
using System.Windows.Forms;
using Logica;
using Modelo.Entities;

namespace Principal
{
    public partial class ActualizarUsuario : Form
    {
        private UsuarioController usuarioController = new UsuarioController();

        public ActualizarUsuario()
        {
            InitializeComponent();
            CargarRoles();
        }

        private void CargarRoles()
        {
            comboBox1.DataSource = Enum.GetValues(typeof(RolUsuario));
        }

        private void btBuscarUsuario_Click(object sender, EventArgs e)
        {
            string documento = tbDocumento.Text.Trim();

            if (string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("Por favor, ingrese un documento.");
                return;
            }

            UsuarioEntity usuario = usuarioController.ConsultarUsuario(documento);

            if (usuario != null)
            {
                tbActualizarNombre.Text = usuario.nombre;
                tbActualizarContraseña.Text = usuario.contraseña;
                comboBox1.SelectedItem = usuario.rol;

                lbUsuarioActualizar.Text = $"Usuario encontrado: {usuario.nombre}";
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
                lbUsuarioActualizar.Text = "";
            }
        }

        private void btActualizarUsuario_Click(object sender, EventArgs e)
        {
            string documento = tbDocumento.Text.Trim();
            string nombre = tbActualizarNombre.Text.Trim();
            string contraseña = tbActualizarContraseña.Text.Trim();
            RolUsuario rolSeleccionado = (RolUsuario)comboBox1.SelectedItem;

            if (string.IsNullOrEmpty(documento) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            UsuarioEntity usuario = new UsuarioEntity
            {
                documento = documento,
                nombre = nombre,
                contraseña = contraseña,
                rol = rolSeleccionado
            };

            string mensaje = usuarioController.ActualizarUsuario(usuario);

            if (mensaje.Contains("correctamente"))
            {
                lbUsuarioActuzalido.Text = $"Usuario actualizado: {usuario.nombre},\n Rol: {usuario.rol}, \n Contraseña: {usuario.contraseña}";
            }
            else
            {
                lbUsuarioActuzalido.Text = mensaje;
            }

            MessageBox.Show(mensaje);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void lbUsuarioActualizar_Click(object sender, EventArgs e) { }

        private void lbUsuarioActuzalido_Click(object sender, EventArgs e) { }

        private void btVolver_Click(object sender, EventArgs e)
        {
            SubMenuUsuarios menu = new SubMenuUsuarios();
            menu.Show();
            this.Hide();
        }
    }
}
