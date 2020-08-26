using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delphos.Models
{
    public class Traspaso
    {
        public int Id { get; set; }
        public int SkuProducto { get; set; }
        public int Cantidad { get; set; }
        public int BodegaOrigen { get; set; }
        public int BodegaDestino { get; set; }
        public DateTime FechaTraspaso { get; set; }


        public virtual BodegaTipo BodegaTipo { get; set; }
        public virtual TraspasoDetalle TraspasoDetalle { get; set; }
        public virtual Producto Producto { get; set; }
    }
}