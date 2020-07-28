using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delphos.Models
{
    public class TraspasoDetalle
    {
        public int Id { get; set; }
        public int IdTraspaso { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public virtual ICollection<Traspaso> Traspasos { get; set; }

    }
}