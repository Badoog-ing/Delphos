﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delphos.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public int Sku { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CategoriaId { get; set; }
        public int Precio { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}