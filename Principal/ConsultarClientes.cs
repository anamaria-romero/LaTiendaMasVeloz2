using System;
using System.Windows.Forms;
using Logica;
using Modelo.Entities;

namespace Principal
{
    public partial class ConsultarClientes : Form
    {
        private ClienteController clienteController;

        public ConsultarClientes()
        {
            InitializeComponent();
            clienteController = new ClienteController();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            string documento = tbDocumento.Text.Trim();

            if (string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("Por favor ingrese un documento para consultar.");
                return;
            }

            ClienteEntity cliente = clienteController.ConsultarCliente(documento);

            if (cliente != null)
            {
                lbMostrarCliente.Text = $"Nombre: {cliente.nombre}\nTeléfono: {cliente.telefono}";
            }
            else
            {
                lbMostrarCliente.Text = "Cliente no encontrado.";
            }
        }

        private void ConsultarClientes_Load(object sender, EventArgs e) { }

        private void lbMostrarCliente_Click(object sender, EventArgs e) { }

        private void btVolver_Click(object sender, EventArgs e)
        {
            SubMenuClientes menu = new SubMenuClientes();
            menu.Show();
            this.Hide();
        }
    }
}
