using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

public static class GeneradorPDF
{
    public static string GenerarFacturaPDF(int idFactura, string nombreCliente, string nombreEmpleado, DataGridView dataGrid, decimal total, decimal efectivo)
    {
        Document doc = new Document();
        string ruta = $"Factura_{idFactura}.pdf";

        try
        {
            PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));
            doc.Open();

            var titulo = new Paragraph("FACTURA", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20))
            {
                Alignment = Element.ALIGN_CENTER
            };
            doc.Add(titulo);

            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph($"Factura #: {idFactura}"));
            doc.Add(new Paragraph($"Cliente: {nombreCliente}"));
            doc.Add(new Paragraph($"Empleado: {nombreEmpleado}"));
            doc.Add(new Paragraph($"Fecha: {DateTime.Now.ToShortDateString()}"));
            doc.Add(new Paragraph("\n"));

            PdfPTable table = new PdfPTable(4);
            table.AddCell("Nombre del artículo");
            table.AddCell("Cantidad");
            table.AddCell("Precio Unitario");
            table.AddCell("Subtotal");

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.IsNewRow) continue;

                table.AddCell(row.Cells["nombreArticulo"].Value?.ToString());
                table.AddCell(row.Cells["cantidad"].Value?.ToString());
                table.AddCell(row.Cells["precioUnitario"].Value?.ToString());
                table.AddCell(row.Cells["subtotal"].Value?.ToString());
            }

            doc.Add(table);
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph($"Total: ${total:F2}"));
            doc.Add(new Paragraph($"Efectivo recibido: ${efectivo:F2}"));
            doc.Add(new Paragraph($"Cambio: ${efectivo - total:F2}"));

            doc.Close();

            // Abre el PDF automáticamente
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = Path.GetFullPath(ruta),
                UseShellExecute = true
            });

            return Path.GetFullPath(ruta);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al generar PDF: " + ex.Message);
            return null;
        }
    }

}

