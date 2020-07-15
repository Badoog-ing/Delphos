using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Delphos.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public int Sku { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CategoriaId { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public int Precio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public virtual ICollection<Venta> Ventas { get; set; }
    }
}