using Modelo;
using Modelo.Entities;
using System;

namespace Logica
{
    public class ProductoProveedorController
    {
        private BaseDatos db = new BaseDatos();

        public void GuardarProductoProveedor(ProductoProveedor productoProveedor)
        {
            if (db.GuardarProductoProveedor(productoProveedor) > 0)
                Console.WriteLine("ProductoProveedor guardado correctamente.");
            else
                Console.WriteLine("Error al guardar ProductoProveedor.");
        }

        public ProductoProveedor ConsultarProductoProveedor(int id)
        {
            return db.MostrarProductoProveedor(id);
        }


        public void ActualizarProductoProveedor(ProductoProveedor productoProveedor)
        {
            if (db.ActualizarProductoProveedor(productoProveedor) > 0)
                Console.WriteLine("ProductoProveedor actualizado correctamente.");
            else
                Console.WriteLine("Error al actualizar el ProductoProveedor.");
        }


        public void EliminarProductoProveedor(int id)
        {
            if (db.EliminarProductoProveedor(id) > 0)
                Console.WriteLine("ProductoProveedor eliminado correctamente.");
            else
                Console.WriteLine("No se encontró el ProductoProveedor a eliminar.");
        }

    }

}

