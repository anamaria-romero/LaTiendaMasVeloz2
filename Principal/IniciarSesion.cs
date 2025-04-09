using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Entities;
using Logica;

namespace Principal
{
    public partial class IniciarSesion : Form
    {
        UsuarioController usuarioController = new UsuarioController();

        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {
            cbCargo.DataSource = Enum.GetValues(typeof(RolUsuario));
        }

        private void tbIngresarNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbContraseñaIniciarSesion_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            string nombre = tbIngresarNombre.Text.Trim();
            string contraseña = tbContraseñaIniciarSesion.Text.Trim();
            string cargoSeleccionado = cbCargo.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(cargoSeleccionado))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UsuarioEntity usuario = usuarioController.ConsultarUsuario(nombre);

            if (usuario == null)
            {
                MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usuario.contraseña == contraseña && usuario.rol.ToString() == cargoSeleccionado)
            {
                MessageBox.Show("Inicio de sesión exitoso", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Sesion.RolUsuario = usuario.rol.ToString();

                MenuPrincipal menu = new MenuPrincipal();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña o cargo incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

