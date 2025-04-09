using System;
using System.Windows.Forms;
using Logica;

namespace Principal
{
    public partial class MenuPrincipal : Form
    {
        private string rolUsuario;

        public MenuPrincipal()
        {
            InitializeComponent();

            rolUsuario = Sesion.RolUsuario;

            if (string.IsNullOrEmpty(rolUsuario))
            {
                MessageBox.Show("No se ha definido el rol del usuario. Cerrando el menú.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }

            AplicarPermisos();
        }

        private void AplicarPermisos()
        {
            switch (rolUsuario.ToLower())
            {
                case "administrador":
                    break;

                case "manoderecha":
                    btUsuarios.Visible = false;
                    break;

                case "empleado":
                    btInventario.Visible = false;
                    btUsuarios.Visible = false;
                    btProveedores.Visible = false;
                    btProductoProveedor.Visible = false;
                    break;

                default:
                    MessageBox.Show("Rol no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    break;
            }
        }

        private void btUsuarios_Click(object sender, EventArgs e)
        {
            SubMenuUsuarios menu = new SubMenuUsuarios();
            menu.Show();
            this.Hide();
        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            SubMenuClientes menu = new SubMenuClientes();
            menu.Show();
            this.Hide();
        }

        private void btEmpleados_Click(object sender, EventArgs e)
        {
            SubMenuUsuarios menu = new SubMenuUsuarios();
            menu.Show();
            this.Hide();
        }

        private void btInventario_Click(object sender, EventArgs e)
        {
            SubMenuProductos menu = new SubMenuProductos();
            menu.Show();
            this.Hide();
        }

        private void btProveedores_Click(object sender, EventArgs e)
        {
            SubMenuProveedores menu = new SubMenuProveedores();
            menu.Show();
            this.Hide();
        }

        private void btVentas_Click(object sender, EventArgs e)
        {
            SubMenuVentas menu = new SubMenuVentas();
            menu.Show();
            this.Hide();
        }

        private void btProductoProveedor_Click(object sender, EventArgs e)
        {
            SubMenuProductoProveedor menu = new SubMenuProductoProveedor();
            menu.Show();
            this.Hide();
        }
    }
}
