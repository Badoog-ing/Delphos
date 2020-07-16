namespace Delphos.Migrations
{
    using Delphos.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<bdSupermercado>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Delphos.Models.bdSupermercado context)
        {
            // Cargo
            context.Cargos.AddOrUpdate(
                c => c.Nombre,
                new Cargo { Id = 1, Nombre = "Administrador" },
                new Cargo { Id = 2, Nombre = "Bodega" },
                new Cargo { Id = 3, Nombre = "Caja" },
                new Cargo { Id = 4, Nombre = "Comercial" }
                );
            context.SaveChanges();

            // Usuario
            context.Usuarios.AddOrUpdate(
                u => u.Rut,
                new Usuario { Id = 1, Nombre = "Felipe", Rut = "16186571-0", Password = "123", CargoId = 1, Estado = "Activo" },
                new Usuario { Id = 2, Nombre = "Jesus", Rut = "16186571-5", Password = "123", CargoId = 2, Estado = "Activo" },
                new Usuario { Id = 3, Nombre = "Fernando", Rut = "16186571-2", Password = "123", CargoId = 3, Estado = "Activo" },
                new Usuario { Id = 4, Nombre = "comercial", Rut = "16186571-k", Password = "123", CargoId = 4, Estado = "Activo" }
                );
            context.SaveChanges();

            // Productos
            context.Productos.AddOrUpdate(
                P => P.Sku,
                new Producto { Id = 1, Sku = 100, Nombre = "Leche",        Descripcion = "Caja 1 litro",               CategoriaId = 1, Precio = 800, FechaCreacion = DateTime.Today },
                new Producto { Id = 2, Sku = 101, Nombre = "Yogurt",       Descripcion = "Soprole",                    CategoriaId = 1, Precio = 200, FechaCreacion = DateTime.Today },
                new Producto { Id = 3, Sku = 102, Nombre = "Gaseosa",      Descripcion = "3 litros ddesechable",       CategoriaId = 2, Precio = 1700, FechaCreacion = DateTime.Today },
                new Producto { Id = 4, Sku = 103, Nombre = "Agua Mineral", Descripcion = "1.6 litros mineral",         CategoriaId = 2, Precio = 600, FechaCreacion = DateTime.Today },
                new Producto { Id = 5, Sku = 104, Nombre = "Chocolate",    Descripcion = "Trencito",                   CategoriaId = 3, Precio = 1200, FechaCreacion = DateTime.Today },
                new Producto { Id = 6, Sku = 105, Nombre = "Alfajor",      Descripcion = "Calaf",                      CategoriaId = 3, Precio = 300, FechaCreacion = DateTime.Today },
                new Producto { Id = 7, Sku = 106, Nombre = "Carne",        Descripcion = "Posta paleta 1 kilo",        CategoriaId = 4, Precio = 8000, FechaCreacion = DateTime.Today },
                new Producto { Id = 8, Sku = 107, Nombre = "Pollo",        Descripcion = "Entero superpollo",          CategoriaId = 4, Precio = 7000, FechaCreacion = DateTime.Today },
                new Producto { Id = 9, Sku = 108, Nombre = "Tallarines",   Descripcion = "Espirales Carozzi 1 kilo",   CategoriaId = 5, Precio = 700, FechaCreacion = DateTime.Today },
                new Producto { Id = 10, Sku = 109, Nombre = "Arroz",       Descripcion = "1 kilo Miraflores",          CategoriaId = 5, Precio = 1000, FechaCreacion = DateTime.Today }
                );
            context.SaveChanges();

            // Bodega
            context.Bodegas.AddOrUpdate(
                b => b.Nombre,
                new TablaBodega { Id = 1, Nombre = "Bodega Principal", Stock = 5, ProductoId = 4 },
                new TablaBodega { Id = 2, Nombre = "Bodega Secundaria", Stock = 7, ProductoId = 5 },
                new TablaBodega { Id = 3, Nombre = "Bodega Principal", Stock = 9, ProductoId = 6 }
                );
            context.SaveChanges();
        }
    }
}
