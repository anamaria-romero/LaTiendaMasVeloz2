﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
    public class ClienteEntity
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string documento { get; set; }
        public string telefono { get; set; }
    }
}
