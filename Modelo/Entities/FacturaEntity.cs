using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    class FacturaEntity
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;

        [ForeignKey("IdCliente")]
        public ClienteEntity Cliente { get; set; }

        [ForeignKey("IdEmpleado")]
        public UsuarioEntity Empleado { get; set; }

        public ICollection<VentaEntity> Ventas { get; set; }
    }
}
