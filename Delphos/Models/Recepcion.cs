﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delphos.Models
{
    public class Recepcion
    {
        public int Id { get; set; }
        public int Factura { get; set; }
        public int OrdenDeCompra { get; set; }
        public DateTime FechasCreacion { get; set; }

    }
}