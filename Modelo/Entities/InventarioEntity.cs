using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    class InventarioEntity
    {
            public int Id { get; set; }
            public int IdProducto { get; set; }
            public int Cantidad { get; set; }

            [ForeignKey("IdProducto")]
            public ProductoEntity Producto { get; set; }
      
    }
}
