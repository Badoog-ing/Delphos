using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delphos.Models
{
    public class OrdenCompra
    {
        //faltan las validaciones
        public int Id { get; set; }
        public int NOrdenDeCompra { get; set; }
      
        //hay que cambiarlo a date
        public String FechaEmision { get; set; }
        //fk usuario
        public String Usuario { get; set; }
        //FK de proveedor
        public String Proveedor { get; set; }

    }
}