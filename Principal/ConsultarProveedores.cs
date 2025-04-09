using System;
using System.Windows.Forms;
using Logica;
using Modelo.Entities;

namespace Principal
{
    public partial class ConsultarProveedores : Form
    {
        private ProveedorController proveedorController;

        public ConsultarProveedores()
        {
            InitializeComponent();
            proveedorController = new ProveedorController();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            string documento = tbDocumento.Text;

            ProveedorEntity proveedor = proveedorController.ConsultarProveedor(documento);

            if (proveedor != null)
            {
                lbMostrarProveedor.Text = $"Proveedor: {proveedor.nombre},\n Teléfono: {proveedor.telefono}, Documento: {proveedor.documento}";
            }
            else
            {
                lbMostrarProveedor.Text = "Proveedor no encontrado.";
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            SubMenuProveedores menu = new SubMenuProveedores();
            menu.Show();
            this.Hide();
        }
    }
}
