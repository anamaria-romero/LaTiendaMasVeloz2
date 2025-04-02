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
            string documento = tbDocumento.Text;
            string mensaje = usuarioController.EliminarUsuario(documento);
            MessageBox.Show(mensaje);
        }
    }
}
