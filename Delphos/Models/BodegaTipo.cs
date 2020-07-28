using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delphos.Models
{
    public class BodegaTipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<TablaBodega> TablaBodegas { get; set; }
        public virtual ICollection<Traspaso> Traspasos { get; set; }
    }
}