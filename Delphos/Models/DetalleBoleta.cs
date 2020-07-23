using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delphos.Models
{
    public class DetalleBoleta
    {
        public int Id { get; set; }
        public int NumeroBoleta { get; set; }
        public string FechaVenta { get; set; }
        public int MetodoPago { get; set; }
        public int TotaldeVenta { get; set; }
        public int Cantidad { get; set; }
        public int Subtotal { get; set; }

    }
}