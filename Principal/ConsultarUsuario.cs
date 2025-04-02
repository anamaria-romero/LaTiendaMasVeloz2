using System;
using System.Data;
using System.Windows.Forms;
using Logica;

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
            string documento = tbDocumentoUsuario.Text;

            DataTable dt = usuarioController.ConsultarUsuario(documento);
            if (dt.Rows.Count > 0)
            {
                lbMostrarUsuario.Text = $"Nombre: {dt.Rows[0]["nombre"]}\nRol: {dt.Rows[0]["rol"]}";
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }
    }
}
