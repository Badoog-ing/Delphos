using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Profile;

namespace Delphos.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Rut(ErrorMessage = "Rut no valido")]
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
        public byte Foto { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public DateTime FechasCreacion { get; set; }

        //fk
        public int CargoId { get; set; }
        public virtual Cargo Cargo { get; set; }

        //de donde sera referenciado
        public virtual ICollection<Proveedor> Proveedores { get; set; }
        public virtual ICollection<OrdenCompra> OrdenCompras { get; set; }
    }


    public class RutAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var rut = Convert.ToString(value);

            /*            if (String.IsNullOrEmpty(rut))
                        {
                            return true;
                        }

                        if (rut.Length > 10 || rut.Length < 9)
                        {
                            return false;
                        }

                        for (int i = 0; i < rut.Length - 2; i++)
                        {
                            if (Char.IsNumber(rut[i]) == false)
                            {
                                return false;
                            }
                        }
                        if (Char.IsNumber(rut[rut.Length - 1]) == true || rut[rut.Length - 1] == 'K' || rut[rut.Length - 1] == 'k')
                        {

                        }
                        else
                        {
                            return false;
                        }
                        if (rut[rut.Length - 2] != '-')
                        {
                            return false;
                        }

                        return true;*/

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
