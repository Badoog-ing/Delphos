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
        
        [Display(Name = "Ap. Paterno")][Required]
        public string ApellidoP { get; set; }
        
        [Display(Name = "Ap. Materno")][Required]
        public string ApellidoM { get; set; }
        [Required]
        public string Direccion { get; set; }
        
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "Dirección de Correo electrónico incorrecta.")][Required]
        public string Email { get; set; }
        [Required]
        public int Telefono { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public DateTime FechasCreacion { get; set; }

        //fk
        [Required]
        public int CargoId { get; set; }
        public virtual Cargo Cargo { get; set; }

        //de donde sera referenciado
        /*public virtual ICollection<Proveedor> Proveedores { get; set; }*/
    }
}