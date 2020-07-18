using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Delphos.Models
{
    public class Proveedor
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Rut { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string Giro { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string RazonSocial { get; set; }

        [Required]
        /*[RegularExpression(@"^[0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@(ua)\.(es)$")]*/
        public string Email { get; set; }

        [Required]
        [Range(8,10)]//0412252626 - 99266273
        public int Telefono { get; set; }

      /*  //fk
        [Required]
        public int UsuarioId { get; set; }
        public virtual Usuario Usuarios { get; set; }*/

    }
}