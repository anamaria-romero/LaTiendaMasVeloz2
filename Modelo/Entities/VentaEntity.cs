using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    class VentaEntity
    {
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }

        [ForeignKey("IdFactura")]
        public FacturaEntity Factura { get; set; }

        [ForeignKey("IdProducto")]
        public ProductoEntity Producto { get; set; }
    }
}
