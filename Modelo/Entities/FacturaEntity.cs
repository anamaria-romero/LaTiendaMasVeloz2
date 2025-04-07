using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class FacturaEntity
    {
        public int id { get; set; }
        public int id_cliente { get; set; }
        public int id_empleado { get; set; }
        public decimal total { get; set; }
        public DateTime fecha { get; set; } = DateTime.Now;
    }


}
