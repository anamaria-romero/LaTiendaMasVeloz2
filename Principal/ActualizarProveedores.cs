using System;
using System.Windows.Forms;
using Logica;
using Modelo.Entities;

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

            ProveedorEntity proveedor = proveedorController.ConsultarProveedor(documento);

            if (proveedor != null)
            {
                tbActualizarNombre.Text = proveedor.nombre;
                tbActualizarTelefono.Text = proveedor.telefono;
            }
            else
            {
                MessageBox.Show("Proveedor no encontrado.");
            }
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            ProveedorEntity proveedor = new ProveedorEntity
            {
                documento = tbDocumento.Text,
                nombre = tbActualizarNombre.Text,
                telefono = tbActualizarTelefono.Text
            };

            bool actualizado = proveedorController.ActualizarProveedor(proveedor);

            if (actualizado)
            {
                lbProveedorActualizado.Text = $"Proveedor actualizado: {proveedor.nombre},\n Teléfono: {proveedor.telefono}, Documento: {proveedor.documento}";
            }
            else
            {
                lbProveedorActualizado.Text = "No se pudo actualizar el proveedor.";
            }

        }

        private void lbProveedorActualizado_Click(object sender, EventArgs e)
        {

        }
    }
}
