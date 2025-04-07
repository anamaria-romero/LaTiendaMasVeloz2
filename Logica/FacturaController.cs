using Modelo;
using Modelo.Entities;

namespace Logica
{
    public class FacturaController
    {
        private BaseDatos db = new BaseDatos();

        public int CrearFactura(FacturaEntity factura)
        {
            return db.CrearFactura(factura);
        }

        public bool AgregarProductoAFactura(ProductosFactura producto)
        {
            return db.AgregarProductoAFactura(producto) > 0;
        }
    }
}
