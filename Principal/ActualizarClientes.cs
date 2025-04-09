using System;
using System.Windows.Forms;
using Logica;
using Modelo.Entities;

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

            ClienteEntity cliente = new ClienteEntity
            {
                documento = documento,
                nombre = nombre,
                telefono = telefono
            };

            string mensaje = clienteController.ActualizarCliente(cliente);

            lbClienteActualizado.Text = mensaje;

            if (mensaje == "Cliente actualizado exitosamente.")
            {
                ClienteEntity clienteActualizado = clienteController.ConsultarCliente(documento);
                if (clienteActualizado != null)
                {
                    lbClienteActualizado.Text = $"Cliente actualizado: {clienteActualizado.nombre},\n Teléfono: {clienteActualizado.telefono}";
                }
            }
        }



        private void btBuscarCliente_Click(object sender, EventArgs e)
        {
            string documento = tbDocumento.Text.Trim();

            if (string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("Por favor ingrese un documento para buscar.");
                return;
            }

            ClienteEntity cliente = clienteController.ConsultarCliente(documento);

            if (cliente != null)
            {
                tbActualizarNombre.Text = cliente.nombre;
                tbActualizarTelefono.Text = cliente.telefono;
                tbDocumento.Text = cliente.documento;

                label1.Text = $"Cliente encontrado: {cliente.nombre}";
            }
            else
            {
                label1.Text = "Cliente no encontrado.";
                tbActualizarNombre.Text = string.Empty;
                tbActualizarTelefono.Text = string.Empty;
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void tbActualizarNombre_TextChanged(object sender, EventArgs e) { }

        private void tbActualizarTelefono_TextChanged(object sender, EventArgs e) { }

        private void lbClienteActualizado_Click(object sender, EventArgs e) { }

        private void btVolver_Click(object sender, EventArgs e)
        {
            SubMenuClientes menu = new SubMenuClientes();
            menu.Show();
            this.Hide();
        }
    }
}
