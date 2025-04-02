using System;
using System.Data;
using System.Windows.Forms;
using Logica;

namespace Principal
{
    public partial class ActualizarClientes : Form
    {
        private ClienteController clienteController;

        public ActualizarClientes()
        {
            InitializeComponent();
            clienteController = new ClienteController();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {

            string nombre = tbActualizarNombre.Text.Trim();
            string telefono = tbActualizarTelefono.Text.Trim();
            string documento = tbDocumento.Text.Trim();

            if (string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("El documento es obligatorio.");
                return;
            }

            if (string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Por favor ingrese al menos un campo para actualizar.");
                return;
            }

            string mensaje = clienteController.ActualizarCliente(nombre, telefono, documento);
            lbClienteActualizado.Text = mensaje;
        }


        private void btBuscarCliente_Click(object sender, EventArgs e)
        {
            string documento = tbDocumento.Text.Trim();

            if (string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("Por favor ingrese un documento para buscar.");
                return;
            }

            DataTable clienteData = clienteController.ConsultarCliente(documento);

            if (clienteData.Rows.Count > 0)
            {
                string nombre = clienteData.Rows[0]["nombre"].ToString();
                string telefono = clienteData.Rows[0]["telefono"].ToString();
                string doc = clienteData.Rows[0]["documento"].ToString();

                tbActualizarNombre.Text = nombre;
                tbActualizarTelefono.Text = telefono;
                tbDocumento.Text = doc;

                label1.Text = $"Cliente encontrado: {nombre}";
            }
            else
            {
                label1.Text = "Cliente no encontrado.";
                tbActualizarNombre.Text = string.Empty;
                tbActualizarTelefono.Text = string.Empty;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbActualizarNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbActualizarTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbClienteActualizado_Click(object sender, EventArgs e)
        {

        }
    }
}
