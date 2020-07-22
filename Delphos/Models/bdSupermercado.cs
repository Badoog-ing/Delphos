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
        public DbSet<TablaBodega> Bodegas { get; set; }

        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<OrdenCompra> OrdenCompras { get; set; }
    }
}
