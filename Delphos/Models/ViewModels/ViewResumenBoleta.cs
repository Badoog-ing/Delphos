using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delphos.Models.ViewModels
{
    public class ViewResumenBoleta
    {
        public Venta Venta { get; set; }

        public DetalleBoleta DetalleBoleta { get; set; }

        public Producto Producto { get; set; }
    }
}