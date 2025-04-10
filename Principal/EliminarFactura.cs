using Logica;
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
    public partial class EliminarFactura : Form
    {
        public EliminarFactura()
        {
            InitializeComponent();
        }

        private void tbIdentificador_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tbIdentificador.Text, out int idFactura))
            {
                lbMostrarFactura.Text = "Ingrese un ID válido.";
                return;
            }

            BaseDatos db = new BaseDatos();
            var factura = db.ObtenerFacturaPorId(idFactura); 

            if (factura == null)
            {
                lbMostrarFactura.Text = "Factura no encontrada.";
                return;
            }

            lbMostrarFactura.Text =
                $"Factura ID: {factura.id}\n" +
                $"Cliente ID: {factura.id_cliente}\n" +
                $"Empleado ID: {factura.id_usuario}\n" +
                $"Total: ${factura.total}\n" +
                $"Fecha: {factura.fecha.ToShortDateString()}";
        }


        private void lbMostrarFactura_Click(object sender, EventArgs e)
        {

        }

        private void btEliminarFactura_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbIdentificador.Text, out int idFactura))
            {
                MessageBox.Show("Ingrese un ID de factura válido.");
                return;
            }

            BaseDatos db = new BaseDatos();

            try
            {
                db.EliminarProductosPorFactura(idFactura);

                db.EliminarFactura(idFactura);

                MessageBox.Show("Factura eliminada correctamente.");
                tbIdentificador.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la factura: " + ex.Message);
            }
        }


        private void btVolver_Click(object sender, EventArgs e)
        {
            SubMenuVentas menu = new SubMenuVentas();
            menu.Show();
            this.Hide();
        }
    }
}
