using Modelo;
using Modelo.Entities;
using System;

namespace Logica
{
    public class ProveedorController
    {
        private BaseDatos db = new BaseDatos();

        public ProveedorEntity ConsultarProveedor(string documento)
        {
            return db.MostrarProveedor(documento);
        }

        public bool GuardarProveedor(ProveedorEntity proveedor)
        {
            return db.GuardarProveedor(proveedor) > 0;
        }

        public bool ActualizarProveedor(ProveedorEntity proveedor)
        {
            return db.ActualizarProveedor(proveedor) > 0;
        }
        public string EliminarProveedor(string documento)
        {
            return db.EliminarProveedor(documento) > 0
                ? "Proveedor eliminado correctamente."
                : "No se encontró el proveedor.";
        }

    }

}

