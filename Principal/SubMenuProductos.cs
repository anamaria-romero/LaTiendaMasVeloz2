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
    public partial class SubMenuProductos : Form
    {
        public SubMenuProductos()
        {
            InitializeComponent();
        }

        private void btSubMenuRegistrarProducto_Click(object sender, EventArgs e)
        {
            Producto frmProducto = new Producto();
            frmProducto.Show();
        }

        private void btSubMenuActualizarProducto_Click(object sender, EventArgs e)
        {
            ActualizarProducto frmActualizar = new ActualizarProducto();
            frmActualizar.Show();
        }

        private void btSubMenuConsultarProducto_Click(object sender, EventArgs e)
        {
            ConsultarProducto frmConsultar = new ConsultarProducto();
            frmConsultar.Show();
        }

        private void btSubMenuEliminarProducto_Click(object sender, EventArgs e)
        {
            EliminarProducto frmEliminar = new EliminarProducto();
            frmEliminar.Show();
        }
    }
}
