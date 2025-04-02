using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class SubMenuProveedores : Form
    {
        public SubMenuProveedores()
        {
            InitializeComponent();
        }

        private void btSubMenuRegistrarProveedores_Click(object sender, EventArgs e)
        {
            Proveedor frmProveedor = new Proveedor();
            frmProveedor.Show();
        }

        private void btSubMenuActualizarProveedores_Click(object sender, EventArgs e)
        {
            ActualizarProveedores frmActualizar = new ActualizarProveedores();
            frmActualizar.Show();
        }

        private void btSubMenuConsultarProveedores_Click(object sender, EventArgs e)
        {
            ConsultarProveedores frmConsultar = new ConsultarProveedores();
            frmConsultar.Show();
        }

        private void btSubMenuEliminarProveedores_Click(object sender, EventArgs e)
        {
            EliminarProveedor frmEliminar = new EliminarProveedor();
            frmEliminar.Show();
        }
    }
}
