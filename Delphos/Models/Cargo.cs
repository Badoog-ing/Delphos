using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Profile;

namespace Delphos.Models
{
    public class Cargo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}




public virtual ICollection<Boleta> Boletas { get; set; }
