using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delphos.Models
{
    public class DetalleBoleta
    {
        public int Id { get; set; }
        public int IdNumeroBoleta { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public int Total { get; set; }
    }
}