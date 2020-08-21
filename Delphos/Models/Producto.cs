using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Script.Serialization;

namespace Delphos.Models
{
    [DataContract(IsReference = true)]
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        [Range(0, 999.99)]
        public int Sku { get; set; }

        [Required]
        [StringLength(12)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public int Precio { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }

        [ScriptIgnore]
        public virtual DetalleBoleta DetalleBoleta { get; set; }
        [ScriptIgnore]
        public virtual ICollection<Venta> Ventas { get; set; }
        [ScriptIgnore]
        public virtual ICollection<TablaBodega> Bodegas { get; set; }
    }

}