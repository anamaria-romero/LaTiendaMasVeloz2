using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class UsuarioEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public RolUsuario Rol { get; set; }
        public string Contraseña { get; set; }
    }

    public enum RolUsuario
    {
        Empleado,
        Administrador,
        ManoDerecha
    }
}