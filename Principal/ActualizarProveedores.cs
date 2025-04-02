using System;
using System.Data;
using System.Windows.Forms;
using Logica;

namespace Principal
{
    public partial class ActualizarProveedores : Form
    {
        private ProveedorController proveedorController;

        public ActualizarProveedores()
        {
            InitializeComponent();
            proveedorController = new ProveedorController();
        }

        private void btBuscarProveedor_Click(object sender, EventArgs e)
        {
            string documento = tbDocumento.Text;

            DataTable dt = proveedorController.ConsultarProveedor(documento);

            if (dt.Rows.Count > 0)
            {
                tbActualizarNombre.Text = dt.Rows[0]["nombre"].ToString();
                tbActualizarTelefono.Text = dt.Rows[0]["telefono"].ToString();
            }
            else
            {
                MessageBox.Show("Proveedor no encontrado.");
            }
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            string documento = tbDocumento.Text;
            string nombre = tbActualizarNombre.Text;
            string telefono = tbActualizarTelefono.Text;

            string resultado = proveedorController.ActualizarProveedor(nombre, telefono, documento);
            lbProveedorActualizado.Text = resultado;
        }
    }
}
