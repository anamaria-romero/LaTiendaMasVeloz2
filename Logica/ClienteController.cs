using Modelo;
using Modelo.Entities;

namespace Logica
{
    public class ClienteController
    {
        private BaseDatos db = new BaseDatos();

        public string GuardarCliente(string documento, string nombre, string telefono)
        {
            ClienteEntity cliente = new ClienteEntity
            {
                documento = documento,
                nombre = nombre,
                telefono = telefono
            };

            int filasAfectadas = db.GuardarCliente(cliente);

            return filasAfectadas > 0
                ? "Cliente registrado exitosamente."
                : "No se pudo registrar el cliente.";
        }

        public ClienteEntity ConsultarCliente(string documento)
        {
            return db.MostrarCliente(documento);
        }

        public string ActualizarCliente(ClienteEntity cliente)
        {
            int filasAfectadas = db.ActualizarCliente(cliente);
            if (filasAfectadas > 0)
            {
                return "Cliente actualizado exitosamente.";
            }
            return "No se pudo actualizar el cliente.";
        }

        public string EliminarCliente(string documento)
        {
            return db.EliminarCliente(documento) > 0
                ? "Cliente eliminado exitosamente."
                : "No se encontró el cliente.";
        }

    }
}
