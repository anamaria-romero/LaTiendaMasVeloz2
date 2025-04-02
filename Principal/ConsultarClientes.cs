using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;  

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

            DataTable clienteData = clienteController.ConsultarCliente(documento);

            if (clienteData.Rows.Count > 0)
            {
                string nombre = clienteData.Rows[0]["nombre"].ToString();
                string telefono = clienteData.Rows[0]["telefono"].ToString();

                lbMostrarCliente.Text = $"Nombre: {nombre}\nTeléfono: {telefono}";
            }
            else
            {
                lbMostrarCliente.Text = "Cliente no encontrado.";
            }
        }

        private void ConsultarClientes_Load(object sender, EventArgs e)
        {

        }

        private void lbMostrarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
