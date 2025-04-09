using Logica;
using Modelo.Entities;
using System;
using System.Windows.Forms;

namespace Principal
{
    public partial class RegistrarIngreso : Form
    {
        private ProductoProveedorController controller = new ProductoProveedorController();

        public RegistrarIngreso()
        {
            InitializeComponent();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoProveedor productoProveedor = new ProductoProveedor
                {
                    IdProducto = int.Parse(tbIdProducto.Text),
                    IdProveedor = int.Parse(tbIdProveedor.Text),
                    FechaIngreso = dateTimePicker1.Value,
                    PrecioCompra = decimal.Parse(tbPrecio.Text),
                    Cantidad = int.Parse(tbCantidad.Text)
                };

                controller.GuardarProductoProveedor(productoProveedor);

                lbProductoProveedorRegistrado.Text = $"Producto Ingresado:" +
                                                     $"- ID Producto: {productoProveedor.IdProducto}\n" +
                                                     $"- ID Proveedor: {productoProveedor.IdProveedor}\n" +
                                                     $"- Fecha Ingreso: {productoProveedor.FechaIngreso.ToShortDateString()}\n" +
                                                     $"- Precio Compra: ${productoProveedor.PrecioCompra}\n" +
                                                     $"- Cantidad: {productoProveedor.Cantidad}";
            }
            catch (Exception ex)
            {
                lbProductoProveedorRegistrado.Text = "Error: " + ex.Message;
            }
        }


        private void btVolver_Click(object sender, EventArgs e)
        {
            SubMenuProductoProveedor menu = new SubMenuProductoProveedor();
            menu.Show();
            this.Hide();
        }
    }
}


