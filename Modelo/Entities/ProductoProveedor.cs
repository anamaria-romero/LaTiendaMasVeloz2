using System;

namespace Modelo.Entities
{
    public class ProductoProveedor
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int IdProveedor { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal PrecioCompra { get; set; }
        public int Cantidad { get; set; }

    }
}
