using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class ProductosFactura
    {
        public int id { get; set; }
        public int id_factura { get; set; }
        public int id_producto { get; set; }
        public int cantidad { get; set; }
        public decimal subtotal { get; set; }

        [ForeignKey("id_factura")]
        public FacturaEntity Factura { get; set; }

        [ForeignKey("id_producto")]
        public ProductoEntity Producto { get; set; }
    }

}
