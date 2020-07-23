using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delphos.Models
{
    public class VentadelDia
    {

        public int Id { get; set; }
        public int NumeroBoleta { get; set; }
        public string FechaVenta { get; set; }
        public int Vendedor { get; set; }
        public int TotaldeVenta { get; set; }
    }
}