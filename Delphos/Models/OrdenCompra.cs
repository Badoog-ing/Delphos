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
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        //FK de proveedor
        public int ProveedorId { get; set; }
        public virtual Proveedor Proveedor { get; set; }


    }
}