using Modelo;
using Modelo.Entities;
using System.Collections.Generic;

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

        public FacturaEntity ConsultarFacturaPorId(int id)
        {
            return db.ConsultarFacturaPorId(id);
        }

        public List<ProductosFactura> ConsultarProductosPorFactura(int idFactura)
        {
            return db.ConsultarProductosPorFactura(idFactura);
        }

        public string ObtenerNombreCliente(int idCliente)
        {
            return db.ObtenerNombreCliente(idCliente);
        }

        public string ObtenerNombreEmpleado(int idEmpleado)
        {
            return db.ObtenerNombreEmpleado(idEmpleado);
        }

        public ProductoEntity ConsultarProducto(int idProducto)
        {
            return db.MostrarProducto(idProducto);
        }
    }
}
