using System;
using System.Data;
using System.Windows.Forms;
using Logica;

namespace Principal
{
    public partial class Usuario : Form
    {
        private UsuarioController usuarioController = new UsuarioController();

        public Usuario()
        {
            InitializeComponent();
            CargarRoles();
        }

        private void CargarRoles()
        {
            cbCargo.Items.Add("Empleado");
            cbCargo.Items.Add("Administrador");
            cbCargo.Items.Add("Mano Derecha");
            cbCargo.SelectedIndex = 0;
        }

        private void btIngresarProveedor_Click(object sender, EventArgs e)
        {
            string documento = tbDocumentoUsuario.Text;
            string nombre = tbNombreUsuario.Text;
            string contraseña = tbContraseñaUsuario.Text;
            string rol = cbCargo.SelectedItem.ToString();

            string mensaje = usuarioController.RegistrarUsuario(nombre, documento, rol, contraseña);
            MessageBox.Show(mensaje);
        }
    }
}
