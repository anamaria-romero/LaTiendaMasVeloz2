using Logica;
using Modelo.Entities;
using System;
using System.Windows.Forms;

namespace Principal
{
    public partial class ActualizarProductoProveedor : Form
    {
        public ActualizarProductoProveedor()
        {
            InitializeComponent();
        }

        private void btBuscarProductoProveedor_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbIdentificadorProductoProveedor.Text, out int id))
            {
                ProductoProveedorController controller = new ProductoProveedorController();
                ProductoProveedor producto = controller.ConsultarProductoProveedor(id);

                if (producto != null)
                {
                    tbActualizarIdProductoProveedor.Text = producto.IdProducto.ToString();
                    dateTimePicker1.Value = producto.FechaIngreso;
                    tbActualizarPrecioProductoProveedor.Text = producto.PrecioCompra.ToString();
                    tbActualizaCantidadProductoProveedor.Text = producto.Cantidad.ToString();
                }
                else
                {
                    lbProductoProveedorActualizado.Text = "No se encontró el producto.";
                }
            }
            else
            {
                lbProductoProveedorActualizado.Text = "ID no válido.";
            }
        }
        private void btVolver_Click(object sender, EventArgs e)
        {
            SubMenuProductoProveedor menu = new SubMenuProductoProveedor();
            menu.Show();
            this.Hide();
        }

        private void lbProductoProveedorActualizado_Click(object sender, EventArgs e)
        {

        }

        private void btActualizarProductoProveedor_Click_1(object sender, EventArgs e)
        {

            if (int.TryParse(tbIdentificadorProductoProveedor.Text, out int idOriginal) &&
                int.TryParse(tbActualizarIdProductoProveedor.Text, out int idProveedor) &&
                decimal.TryParse(tbActualizarPrecioProductoProveedor.Text, out decimal precio) &&
                int.TryParse(tbActualizaCantidadProductoProveedor.Text, out int cantidad))
            {
                ProductoProveedorController controller = new ProductoProveedorController();
                ProductoProveedor existente = controller.ConsultarProductoProveedor(idOriginal);

                if (existente != null)
                {
                    existente.IdProveedor = idProveedor;
                    existente.PrecioCompra = precio;
                    existente.Cantidad = cantidad;
                    existente.FechaIngreso = dateTimePicker1.Value;

                    controller.ActualizarProductoProveedor(existente);

                    lbProductoProveedorActualizado.Text =
                        $"Actualizado: Producto ID={existente.IdProducto}, Proveedor ID={existente.IdProveedor},\n " +
                        $"Fecha={existente.FechaIngreso.ToShortDateString()},\n Precio={existente.PrecioCompra}, \n" +
                        $"Cantidad={existente.Cantidad}";
                }
                else
                {
                    lbProductoProveedorActualizado.Text = "Producto no encontrado.";
                }
            }
            else
            {
                lbProductoProveedorActualizado.Text = "Verifica que todos los campos tengan el formato correcto.";
            }
        }

       
        private void tbActualizarIdProductoProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbActualizaCantidadProductoProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIdentificadorProductoProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbActualizarPrecioProductoProveedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
