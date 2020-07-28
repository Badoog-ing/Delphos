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

        //
        //public DateTime FechaCreacion { get; set; }
        public string FechaEmision { get; set; }
        //fk usuario
        public string Usuario { get; set; }
        //FK de proveedor
        public String Proveedor { get; set; }

    }
}