using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Profile;

namespace Delphos.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        public string Rut { get; set; }
        [Required]
        [StringLength(12)]
        public string Nombre { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int CargoId { get; set; }
        public Boolean Estado { get; set; }

        public virtual Cargo Cargo { get; set; }
    }
}