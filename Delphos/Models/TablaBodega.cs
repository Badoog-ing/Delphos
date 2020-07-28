using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delphos.Models
{
    public class TablaBodega
    {
        public int Id { get; set; }
        public int TipoBodega { get; set; }
        public int Stock { get; set; }
        public int ProductoId { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual BodegaTipo BodegaTipo { get; set; }

    }
}