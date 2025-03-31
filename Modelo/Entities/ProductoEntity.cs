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
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int? IdProveedor { get; set; }
        public string Referencia { get; set; }

        [ForeignKey("IdProveedor")]
        public ProveedorEntity Proveedor { get; set; }
    }
}
