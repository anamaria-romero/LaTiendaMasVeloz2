using System;
using System.Data;
using System.Windows.Forms;
using Logica;

namespace Principal
{
    public partial class EliminarClientes : Form
    {
        private ClienteController clienteController;

        public EliminarClientes()
        {
            InitializeComponent();
            clienteController = new ClienteController();
        }

        private void btEliminarCliente_Click(object sender, EventArgs e)
        {
            string documento = tbDocumento.Text.Trim();

            if (string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("Por favor ingrese un documento para eliminar.");
                return;
            }

            DataTable clienteData = clienteController.ConsultarCliente(documento);

            if (clienteData.Rows.Count > 0)
            {
                string nombre = clienteData.Rows[0]["nombre"].ToString();
                string mensaje = clienteController.EliminarCliente(documento);

                lbMostrarCliente.Text = $"Cliente {nombre} eliminado correctamente.";
            }
            else
            {
                lbMostrarCliente.Text = "Cliente no encontrado.";
            }
        }
    }
}
