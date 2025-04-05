using Modelo.Entities;
using Modelo;

namespace Logica
{
    public class UsuarioController
    {
        private BaseDatos db = new BaseDatos();

        public string GuardarUsuario(UsuarioEntity usuario)
        {
            if (db.GuardarUsuario(usuario) > 0)
            {
                return "Usuario guardado correctamente.";
            }
            else
            {
                return "Error al guardar el usuario.";
            }
        }


        public UsuarioEntity ConsultarUsuario(string documento)
        {
            return db.MostrarUsuario(documento);
        }

        public string ActualizarUsuario(UsuarioEntity usuario)
        {
            int filasAfectadas = db.ActualizarUsuario(usuario);
            return filasAfectadas > 0 ? "Usuario actualizado correctamente." : "No se pudo actualizar el usuario.";
        }

        public string EliminarUsuario(string documento)
        {
            return db.EliminarUsuario(documento) > 0
                ? "Usuario eliminado exitosamente."
                : "No se encontró el usuario.";
        }

    }
}
