using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delphos.Models
{
    public class Traspaso
    {
        public int Id { get; set; }
        public DateTime FechaTraspaso { get; set; }
        public string BodegaOrigen { get; set; }
        public string BodegaDestino { get; set; }

    }
}