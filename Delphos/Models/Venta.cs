using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delphos.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public int NumeroBoleta { get; set; }
        public string FechaVenta { get; set; }
        public int IdVendedor { get; set; }
        public int IdProducto { get; set; }
        public virtual Producto Producto { get; set; }
    }
}