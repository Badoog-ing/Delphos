using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delphos.Models
{
    public class TablaBodega
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public int ProductoId { get; set; }
        public virtual Producto Producto { get; set; }
    }
}