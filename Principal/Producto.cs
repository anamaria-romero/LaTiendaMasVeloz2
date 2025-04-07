using System;
using System.Windows.Forms;
using Logica;

namespace Principal
{
    public partial class Producto : Form
    {
        private ProductoController productoController;

        public Producto()
        {
            InitializeComponent();
            productoController = new ProductoController();
        }



        private void btRegistrarProducto_Click(object sender, EventArgs e)
        {
            string nombre = tbNombreProducto.Text.Trim();
            string marca = tbMarcaProducto.Text.Trim();
            int cantidad = int.TryParse(tbCantidadProducto.Text.Trim(), out int cantidadVal) ? cantidadVal : 0;
            decimal precio = decimal.TryParse(tbPrecioProducto.Text.Trim(), out decimal precioVal) ? precioVal : 0m;
            string referencia = tbReferenciaProducto.Text.Trim();
            int? idProveedor = int.TryParse(tbIngreseProveedor.Text.Trim(), out int idProveedorVal) ? idProveedorVal : (int?)null;

            if (string.IsNullOrEmpty(nombre) || cantidad <= 0 || precio <= 0 || string.IsNullOrEmpty(referencia))
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.");
                return;
            }

            ProductoEntity producto = new ProductoEntity
            {
                nombre = nombre,
                marca = marca,
                cantidad = cantidad,
                precio = precio,
                referencia = referencia,
                id_proveedor = idProveedor
            };

            try
            {
                productoController.GuardarProducto(producto);
                MessageBox.Show("Producto registrado correctamente.");

                lbProductoRegistrado.Text = $"Producto registrado: {producto.nombre}, Marca: {producto.marca}, Cantidad: {producto.cantidad}, Precio: ${producto.precio}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el producto: " + ex.Message);
                lbProductoRegistrado.Text = "";
            }
        }

        private void tbReferenciaProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbProductoRegistrado_Click(object sender, EventArgs e)
        {

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            SubMenuProductos menu = new SubMenuProductos();
            menu.Show();
            this.Hide();
        }
    }
}
