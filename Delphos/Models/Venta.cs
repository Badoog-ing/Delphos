using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delphos.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int Sku_venta { get; set; }
        public virtual Producto Producto { get; set; }
    }
}