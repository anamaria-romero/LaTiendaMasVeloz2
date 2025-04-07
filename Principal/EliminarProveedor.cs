using System;
using System.Windows.Forms;
using Logica;

namespace Principal
{
    public partial class EliminarProveedor : Form
    {
        private ProveedorController proveedorController;

        public EliminarProveedor()
        {
            InitializeComponent();
            proveedorController = new ProveedorController();
        }

        private void btEliminarProveedor_Click(object sender, EventArgs e)
        {
            string documento = tbDocumento.Text.Trim();

            if (string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("Por favor, ingrese el documento del proveedor.");
                return;
            }

            var proveedor = proveedorController.ConsultarProveedor(documento);

            if (proveedor != null)
            {
                lbMostrarProveedor.Text = $"Proveedor eliminado: {proveedor.nombre},\n Teléfono: {proveedor.telefono}, Documento: {proveedor.documento}";

                string mensaje = proveedorController.EliminarProveedor(documento);
                MessageBox.Show(mensaje);
            }
            else
            {
                lbMostrarProveedor.Text = "Proveedor no encontrado.";
                MessageBox.Show("Proveedor no encontrado.");
            }
        }


        private void lbMostrarProveedor_Click(object sender, EventArgs e)
        {

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            SubMenuProveedores menu = new SubMenuProveedores();
            menu.Show();
            this.Hide();
        }
    }
}
