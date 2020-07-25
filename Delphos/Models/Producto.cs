using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Delphos.Models
{
    public class Producto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Sku { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public int CategoriaId { get; set; }
        [Required]

        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public int Precio { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        public virtual DetalleBoleta DetalleBoleta { get; set; }
        public virtual ICollection<Venta> Ventas { get; set; }
        public virtual ICollection<TablaBodega> Bodegas { get; set; }
    }

}