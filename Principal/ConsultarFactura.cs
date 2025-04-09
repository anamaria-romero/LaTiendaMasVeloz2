using Logica;
using Modelo.Entities;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Principal
{
    public partial class ConsultarFactura : Form
    {
        private FacturaController facturaController = new FacturaController();
        private string rutaPDF = "";

        public ConsultarFactura()
        {
            InitializeComponent();
            LinkFacturaPDF.Visible = false;
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbIdentificadorFactura.Text, out int idFactura))
            {
                MessageBox.Show("Por favor ingrese un ID válido.");
                return;
            }

            var factura = facturaController.ConsultarFacturaPorId(idFactura);
            var productos = facturaController.ConsultarProductosPorFactura(idFactura);

            if (factura == null || productos.Count == 0)
            {
                MessageBox.Show("Factura no encontrada o sin productos.");
                return;
            }

            string nombreCliente = facturaController.ObtenerNombreCliente(factura.id_cliente);
            string nombreEmpleado = facturaController.ObtenerNombreEmpleado(factura.id_usuario);

            DataGridView tabla = new DataGridView();

            tabla.Columns.Add("nombreArticulo", "Nombre del artículo");
            tabla.Columns.Add("cantidad", "Cantidad");
            tabla.Columns.Add("precioUnitario", "Precio Unitario");
            tabla.Columns.Add("subtotal", "Subtotal");


            foreach (var item in productos)
            {
                var producto = facturaController.ConsultarProducto(item.id_producto);
                decimal precioUnitario = item.subtotal / item.cantidad;
                tabla.Rows.Add(producto.nombre, item.cantidad, precioUnitario.ToString("F2"), item.subtotal.ToString("F2"));
            }

            decimal efectivo = factura.total;

            rutaPDF = GeneradorPDF.GenerarFacturaPDF(idFactura, nombreCliente, nombreEmpleado, tabla, factura.total, efectivo);

            if (!string.IsNullOrEmpty(rutaPDF))
            {
                LinkFacturaPDF.Text = "Ver factura PDF";
                LinkFacturaPDF.Visible = true;
            }
        }


        private void btVolver_Click(object sender, EventArgs e)
        {
            SubMenuVentas menu = new SubMenuVentas();
            menu.Show();
            this.Hide();
        }

        private void LinkFacturaPDF_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(rutaPDF) && System.IO.File.Exists(rutaPDF))
            {
                Process.Start(rutaPDF);
            }
            else
            {
                MessageBox.Show("Archivo PDF no encontrado.");
            }
        }
    }
}
