using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Delphos.Models
{
    public class bdSupermercado : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Recepcion> Recepciones { get; set; }
        public DbSet<Venta> Ventas { get; set; }
    }
}
