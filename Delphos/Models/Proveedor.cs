using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Delphos.Models
{
    public class Proveedor
    {
        public int Id { get; set; }

        [RutP(ErrorMessage = "Ingrese un RUT valido")]
        [Required]
        public string Rut { get; set; }
       
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Nombre no cumple con los requisitos")]
        [Required]
        public string Nombre { get; set; }

        [StringLength(30, MinimumLength = 5, ErrorMessage = "Giro no cumple con los requisitos")]
        [Required]
        public string Giro { get; set; }

        [StringLength(30, MinimumLength = 5, ErrorMessage = "Razon Social no cumple con los requisitos")]
        [Required]
        public string RazonSocial { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        [Required]
        public string Email { get; set; }

        /*[Range(8, 10)]//0412252626 - 99266273*/
        [Required]
        public int Telefono { get; set; }

      //fk

        public int UsuarioId_FK { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<OrdenCompra> OrdenCompras { get; set; }

    }

    public class RutPAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {

            var rut = Convert.ToString(value);

            rut = rut.ToUpper();
            rut = rut.Replace(".", "");
            rut = rut.Replace("-", "");

            int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

            char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

            int m = 0, s = 1;
            for (; rutAux != 0; rutAux /= 10)
            {
                s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
            }
            if (dv == (char)(s != 0 ? s + 47 : 75))
            {
                return true;
            }

            return false;
        }
    }
}