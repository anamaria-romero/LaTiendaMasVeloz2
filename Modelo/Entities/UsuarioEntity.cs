using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class UsuarioEntity
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public RolUsuario rol { get; set; }
        public string contraseña { get; set; }
    }

    public enum RolUsuario
    {
        Empleado,
        Administrador,
        ManoDerecha
    }
}