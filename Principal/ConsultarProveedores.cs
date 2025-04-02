using System;
using System.Data;
using System.Windows.Forms;
using Logica;

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

            DataTable dt = proveedorController.ConsultarProveedor(documento);

            if (dt.Rows.Count > 0)
            {
                lbMostrarProveedor.Text = $"Proveedor: {dt.Rows[0]["nombre"]}, Teléfono: {dt.Rows[0]["telefono"]}, Documento: {dt.Rows[0]["documento"]}";
            }
            else
            {
                lbMostrarProveedor.Text = "Proveedor no encontrado.";
            }
        }
    }
}
