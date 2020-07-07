namespace Delphos.Migrations
{
    using Delphos.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Delphos.Models.bdSupermercado>
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
                new Usuario { Id = 1, Nombre = "Felipe", Rut = "16186571-0", Password = "123", CargoId = 1, Estado = true },
                new Usuario { Id = 2, Nombre = "Jesus", Rut = "16186571-5", Password = "123", CargoId = 2, Estado = true },
                new Usuario { Id = 3, Nombre = "Fernando", Rut = "16186571-k", Password = "123", CargoId = 3, Estado = true },
                new Usuario { Id = 4, Nombre = "comercial", Rut = "16186571-k", Password = "123", CargoId = 4, Estado = true }
                );
            context.SaveChanges();
        }
    }
}
