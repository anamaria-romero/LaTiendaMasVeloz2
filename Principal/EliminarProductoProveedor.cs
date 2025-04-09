using Logica;
using Modelo.Entities;
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
    public partial class EliminarProductoProveedor : Form
    {
        public EliminarProductoProveedor()
        {
            InitializeComponent();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            SubMenuProductoProveedor menu = new SubMenuProductoProveedor();
            menu.Show();
            this.Hide();
        }

        private void tbIdentificadorProductoProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbMostrarProductoProveedor_Click(object sender, EventArgs e)
        {

        }

        private void btEliminarProductoProveedor_Click(object sender, EventArgs e)
        {
        if (int.TryParse(tbIdentificadorProductoProveedor.Text, out int id))
        {
            ProductoProveedorController controller = new ProductoProveedorController();
            ProductoProveedor producto = controller.ConsultarProductoProveedor(id);

            if (producto != null)
            {
                controller.EliminarProductoProveedor(id);
                lbMostrarProductoProveedor.Text =
                    $"ProductoProveedor eliminado:\nProducto ID={producto.IdProducto}, Proveedor ID={producto.IdProveedor}, " +
                    $"Fecha={producto.FechaIngreso.ToShortDateString()}, Precio={producto.PrecioCompra}, Cantidad={producto.Cantidad}";
            }
            else
            {
                lbMostrarProductoProveedor.Text = "No se encontró un ProductoProveedor con ese ID.";
            }
        }
        else
        {
            lbMostrarProductoProveedor.Text = "ID no válido. Ingrese un número.";
        }
    }

}
}
