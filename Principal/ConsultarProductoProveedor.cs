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
    public partial class ConsultarProductoProveedor : Form
    {
        public ConsultarProductoProveedor()
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



        private void btConsultarProductoProveedor_Click(object sender, EventArgs e)
        {
        if (int.TryParse(tbIdentificadorProductoProveedor.Text, out int id))
        {
            ProductoProveedorController controller = new ProductoProveedorController();
            ProductoProveedor resultado = controller.ConsultarProductoProveedor(id);

            if (resultado != null)
            {
                lbMostrarProductoProveedor.Text = $"ID: {resultado.Id}\n" +
                                                   $"ID Producto: {resultado.IdProducto}\n" +
                                                   $"ID Proveedor: {resultado.IdProveedor}\n" +
                                                   $"Fecha Ingreso: {resultado.FechaIngreso.ToShortDateString()}\n" +
                                                   $"Precio Compra: ${resultado.PrecioCompra}\n" +
                                                   $"Cantidad: {resultado.Cantidad}";
            }
            else
            {
                lbMostrarProductoProveedor.Text = "No se encontró ningún registro con ese ID.";
            }
        }
        else
        {
            lbMostrarProductoProveedor.Text = "Ingrese un ID válido.";
        }
    }

}
}
