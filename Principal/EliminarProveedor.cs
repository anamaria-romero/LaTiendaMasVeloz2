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
            string documento = tbDocumento.Text;

            string resultado = proveedorController.EliminarProveedor(documento);
            lbMostrarProveedor.Text = resultado;
        }
    }
}
