using System;
using System.Windows.Forms;
using Logica;

namespace Principal
{
    public partial class Cliente : Form
    {
        private ClienteController clienteController = new ClienteController();

        public Cliente()
        {
            InitializeComponent();
        }
        private void btIngresarCliente_Click(object sender, EventArgs e)
        {
            string nombre = tbNombreCliente.Text;
            string telefono = tbTelefonoCliente.Text;
            string documento = tbDocumentoCliente.Text; 

            string mensaje = clienteController.RegistrarCliente(nombre, telefono, documento);

            MessageBox.Show(mensaje);
        }
    }
}
