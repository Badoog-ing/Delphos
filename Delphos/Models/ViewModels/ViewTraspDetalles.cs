using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Profile;

namespace Delphos.Models.ViewModels
{
    public class ViewTraspDetalles
    {
        public Traspaso Traspaso { get; set; }
        public Producto Producto { get; set; }
        public TraspasoDetalle TraspasoDetalle { get; set; }
    }
}