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
                new Usuario { Id = 1, Nombre = "Felipe", Rut = "16186571-0", ApellidoP = "Villa", ApellidoM = "Molina", Direccion = "Casa 0000", Email = "a@a.cl", Telefono = 123456789, Password = "123", CargoId = 1, Estado = "Activo", FechasCreacion = new DateTime(2020, 5, 10, 12, 30, 00) },
                new Usuario { Id = 2, Nombre = "Bodega", Rut = "17186571-5", ApellidoP = "Toledo", ApellidoM = "Nazaret", Direccion = "Casa 0000", Email = "a@a.cl", Telefono = 123456789, Password = "123", CargoId = 2, Estado = "Activo", FechasCreacion = new DateTime(2020, 4, 10, 12, 30, 00) },
                new Usuario { Id = 3, Nombre = "Fernando", Rut = "18186571-2", ApellidoP = "Orellana", ApellidoM = "Cadiz", Direccion = "Casa 0000", Email = "a@a.cl", Telefono = 123456789, Password = "123", CargoId = 3, Estado = "Activo", FechasCreacion = new DateTime(2020, 3, 10, 12, 30, 00) },
                new Usuario { Id = 4, Nombre = "Jesus", Rut = "19186571-k", ApellidoP = "ApellidoP", ApellidoM = "ApellidoM", Direccion = "Casa 0000", Email = "a@a.cl", Telefono = 123456789, Password = "123", CargoId = 4, Estado = "Activo", FechasCreacion = new DateTime(2020, 2, 10, 12, 30, 00) }
                );
            context.SaveChanges();

            // Productos
            context.Productos.AddOrUpdate(
                P => P.Sku,
                new Producto { Id = 1, Sku = 100, Nombre = "Leche", Descripcion = "Caja 1 litro", CategoriaId = 1, Precio = 800, FechaCreacion = DateTime.Today },
                new Producto { Id = 2, Sku = 101, Nombre = "Yogurt", Descripcion = "Soprole", CategoriaId = 1, Precio = 200, FechaCreacion = DateTime.Today },
                new Producto { Id = 3, Sku = 102, Nombre = "Gaseosa", Descripcion = "3 litros ddesechable", CategoriaId = 2, Precio = 1700, FechaCreacion = DateTime.Today },
                new Producto { Id = 4, Sku = 103, Nombre = "Agua Mineral", Descripcion = "1.6 litros mineral", CategoriaId = 2, Precio = 600, FechaCreacion = DateTime.Today },
                new Producto { Id = 5, Sku = 104, Nombre = "Chocolate", Descripcion = "Trencito", CategoriaId = 3, Precio = 1200, FechaCreacion = DateTime.Today },
                new Producto { Id = 6, Sku = 105, Nombre = "Alfajor", Descripcion = "Calaf", CategoriaId = 3, Precio = 300, FechaCreacion = DateTime.Today },
                new Producto { Id = 7, Sku = 106, Nombre = "Carne", Descripcion = "Posta paleta 1 kilo", CategoriaId = 4, Precio = 8000, FechaCreacion = DateTime.Today },
                new Producto { Id = 8, Sku = 107, Nombre = "Pollo", Descripcion = "Entero superpollo", CategoriaId = 4, Precio = 7000, FechaCreacion = DateTime.Today },
                new Producto { Id = 9, Sku = 108, Nombre = "Tallarines", Descripcion = "Espirales Carozzi 1 kilo", CategoriaId = 5, Precio = 700, FechaCreacion = DateTime.Today },
                new Producto { Id = 10, Sku = 109, Nombre = "Arroz", Descripcion = "1 kilo Miraflores", CategoriaId = 5, Precio = 1000, FechaCreacion = DateTime.Today }
                );
            context.SaveChanges();

            /* // Bodega
             context.Bodegas.AddOrUpdate(
                 b => b.Nombre,
                 new TablaBodega { Id = 1, Nombre = "Bodega Principal", Stock = 5, ProductoId = 4 },
                 new TablaBodega { Id = 2, Nombre = "Bodega Secundaria", Stock = 7, ProductoId = 5 },
                 new TablaBodega { Id = 3, Nombre = "Bodega Principal", Stock = 9, ProductoId = 6 }
                 );
             context.SaveChanges();*/

            //proveedor
            context.Proveedores.AddOrUpdate(
                p => p.Rut,
                new Proveedor { Id = 1, Rut = "87765000-6", Nombre = "Comercial Ruver", Giro = "Fabrica de Masas", RazonSocial = "Versluys", Email = "jtoledo@versluys.cl", Telefono = 99266273 },
                new Proveedor { Id = 2, Rut = "78129870-0", Nombre = "Comercial Yolanda", Giro = "Fabrica de Masas", RazonSocial = "Versluys", Email = "jtoledo@versluys.cl", Telefono = 99266273 }
                );
                context.SaveChanges();

            //OrdenCompra
            context.OrdenCompras.AddOrUpdate(
                p => p.Id,
                new OrdenCompra { Id = 1, NOrdenDeCompra = 1, FechaEmision = "2020-07-21", Usuario = "Comercial", Proveedor = "Comercial Ruver" },
                new OrdenCompra { Id = 2, NOrdenDeCompra = 2, FechaEmision = "2020-07-22", Usuario = "Comercial", Proveedor = "Comercial Yolanda" },
                new OrdenCompra { Id = 3, NOrdenDeCompra = 5, FechaEmision = "2020-07-25", Usuario = "Comercial", Proveedor = "Comercial CCU" }
                );
            context.SaveChanges();

            //VentadelDia
            context.Ventas.AddOrUpdate(
                p => p.Id,
                new Venta { Id = 1, NumeroBoleta = 123, FechaVenta = "2020-07-11", IdVendedor = 1, IdProducto = 2 },
                new Venta { Id = 2, NumeroBoleta = 124, FechaVenta = "2020-07-11", IdVendedor = 2, IdProducto = 3 },
                new Venta { Id = 3, NumeroBoleta = 125, FechaVenta = "2020-07-12", IdVendedor = 1, IdProducto = 4 },
                new Venta { Id = 4, NumeroBoleta = 126, FechaVenta = "2020-07-13", IdVendedor = 2, IdProducto = 5 }
                );
            context.SaveChanges();

            //Traspasos
            context.Traspasos.AddOrUpdate(
                t => t.Id,
                new Traspaso { Id = 1, FechaTraspaso = DateTime.Today, BodegaOrigen = "Central", BodegaDestino = "Sala de Ventas" },
                new Traspaso { Id = 2, FechaTraspaso = DateTime.Today, BodegaOrigen = "Sala de Ventas", BodegaDestino = "Central" },
                new Traspaso { Id = 3, FechaTraspaso = DateTime.Today, BodegaOrigen = "Central", BodegaDestino = "Sala de Ventas" },
                new Traspaso { Id = 4, FechaTraspaso = DateTime.Today, BodegaOrigen = "Sala de Ventas", BodegaDestino = "Central" }
                );
            context.SaveChanges();

            //Recepcion
            context.Recepciones.AddOrUpdate(
                r => r.Id,
                new Recepcion { Id = 1, Factura = 000005, OrdenDeCompra = 1, FechasCreacion = DateTime.Today }
                );
            context.SaveChanges();

        }
    }
}
