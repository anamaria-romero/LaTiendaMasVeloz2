using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class ProductoEntity
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public int? id_proveedor { get; set; }
        public string referencia { get; set; }

        [ForeignKey("id_proveedor")]
        public ProveedorEntity Proveedor { get; set; } 

    }
}
