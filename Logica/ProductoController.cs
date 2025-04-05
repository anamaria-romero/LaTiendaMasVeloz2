using Modelo.Entities;
using Modelo;
using System;

namespace Logica
{
    public class ProductoController
    {
        private BaseDatos db = new BaseDatos();

        public void GuardarProducto(ProductoEntity producto)
        {
            if (db.GuardarProducto(producto) > 0)
                Console.WriteLine("Producto guardado exitosamente.");
            else
                Console.WriteLine("Error al guardar el producto.");
        }

        public void ActualizarProducto(ProductoEntity producto)
        {
            if (db.ActualizarProducto(producto) > 0)
                Console.WriteLine("Producto actualizado exitosamente.");
            else
                Console.WriteLine("No se pudo actualizar el producto.");
        }
        public bool EliminarProducto(int id)
        {
            return db.EliminarProducto(id) > 0;
        }


        public ProductoEntity ConsultarProducto(int id)
        {
            return db.MostrarProducto(id);
        }

    }
}
