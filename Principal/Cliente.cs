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

            string mensaje = clienteController.GuardarCliente(documento, nombre, telefono);

            MessageBox.Show(mensaje);

            lbClienteIngresado.Text = $"Cliente: {nombre},\nTeléfono: {telefono}, Documento: {documento}";
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            SubMenuClientes menu = new SubMenuClientes();
            menu.Show();
            this.Hide();
        }

        private void lbClienteIngresado_Click(object sender, EventArgs e)
        {

        }
    }
}
