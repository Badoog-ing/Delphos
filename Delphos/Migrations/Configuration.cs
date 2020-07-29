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

            context.BodegaTipos.AddOrUpdate(
            bt => bt.Id,
                new BodegaTipo { Id = 1, Nombre = "Bodega Principal" },
                new BodegaTipo { Id = 2, Nombre = "Bodega Secundaria" }
            );
            context.SaveChanges();

            // Bodega
            context.Bodegas.AddOrUpdate(
                b => b.Id,
                new TablaBodega { Id = 1, TipoBodega = 1, Stock = 5, ProductoId = 1 },
                new TablaBodega { Id = 2, TipoBodega = 2, Stock = 7, ProductoId = 2 },
                new TablaBodega { Id = 3, TipoBodega = 1, Stock = 9, ProductoId = 3 },
                new TablaBodega { Id = 4, TipoBodega = 1, Stock = 5, ProductoId = 4 },
                new TablaBodega { Id = 5, TipoBodega = 2, Stock = 7, ProductoId = 5 },
                new TablaBodega { Id = 6, TipoBodega = 1, Stock = 9, ProductoId = 6 },
                new TablaBodega { Id = 7, TipoBodega = 1, Stock = 5, ProductoId = 7 },
                new TablaBodega { Id = 8, TipoBodega = 2, Stock = 7, ProductoId = 8 },
                new TablaBodega { Id = 9, TipoBodega = 1, Stock = 9, ProductoId = 9 }
                );
            context.SaveChanges();

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
                new OrdenCompra { Id = 1, NOrdenDeCompra = 1, FechaEmision = "2020-07-21", Usuario = "Fernando" , Proveedor = "Comercial Ruver" },
                new OrdenCompra { Id = 2, NOrdenDeCompra = 2, FechaEmision = "2020-07-22", Usuario = "Felipe", Proveedor = "Comercial Yolanda" },
                new OrdenCompra { Id = 3, NOrdenDeCompra = 5, FechaEmision = "2020-07-25", Usuario = "Jesus", Proveedor = "Comercial Yolanda" }
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

            //productos dentro de la boleta
            context.DetalleBoletas.AddOrUpdate(
                p => p.Id,
                new DetalleBoleta { Id = 1, IdNumeroBoleta = 123, IdProducto = 101, Cantidad = 1, Total = 100 },
                new DetalleBoleta { Id = 2, IdNumeroBoleta = 123, IdProducto = 104, Cantidad = 2, Total = 3000 },
                new DetalleBoleta { Id = 3, IdNumeroBoleta = 124, IdProducto = 103, Cantidad = 3, Total = 4000 },
                new DetalleBoleta { Id = 4, IdNumeroBoleta = 124, IdProducto = 107, Cantidad = 5, Total = 5000 },
                 new DetalleBoleta { Id = 5, IdNumeroBoleta = 125, IdProducto = 101, Cantidad = 7, Total = 4000 },
                  new DetalleBoleta { Id = 6, IdNumeroBoleta = 125, IdProducto = 107, Cantidad = 6, Total = 4000 },
                   new DetalleBoleta { Id = 7, IdNumeroBoleta = 126, IdProducto = 103, Cantidad = 5, Total = 4000 },
                    new DetalleBoleta { Id = 8, IdNumeroBoleta = 126, IdProducto = 101, Cantidad = 2, Total = 4000 }
                );
            context.SaveChanges();

            //Traspasos
            context.Traspasos.AddOrUpdate(
                t => t.Id,
                new Traspaso { Id = 1, FechaTraspaso = DateTime.Today, BodegaOrigen = 1, BodegaDestino = 2 },
                new Traspaso { Id = 2, FechaTraspaso = DateTime.Today, BodegaOrigen = 2, BodegaDestino = 1 },
                new Traspaso { Id = 3, FechaTraspaso = DateTime.Today, BodegaOrigen = 1, BodegaDestino = 2 },
                new Traspaso { Id = 4, FechaTraspaso = DateTime.Today, BodegaOrigen = 2, BodegaDestino = 1 }
                );
            context.SaveChanges();

            //Traspasos detalles
            context.TraspasoDetalles.AddOrUpdate(
                t => t.Id,
                new TraspasoDetalle { Id = 1, IdTraspaso = 1, IdProducto = 101, Cantidad = 2 },
                new TraspasoDetalle { Id = 2, IdTraspaso = 1, IdProducto = 104, Cantidad = 3 },
                new TraspasoDetalle { Id = 3, IdTraspaso = 1, IdProducto = 102, Cantidad = 2 },
                new TraspasoDetalle { Id = 4, IdTraspaso = 1, IdProducto = 103, Cantidad = 4 },
                new TraspasoDetalle { Id = 5, IdTraspaso = 2, IdProducto = 108, Cantidad = 2 },
                new TraspasoDetalle { Id = 6, IdTraspaso = 2, IdProducto = 107, Cantidad = 3 },
                new TraspasoDetalle { Id = 7, IdTraspaso = 2, IdProducto = 106, Cantidad = 2 },
                new TraspasoDetalle { Id = 8, IdTraspaso = 2, IdProducto = 105, Cantidad = 4 },
                new TraspasoDetalle { Id = 9, IdTraspaso = 3, IdProducto = 101, Cantidad = 2 },
                new TraspasoDetalle { Id = 10, IdTraspaso = 3, IdProducto = 109, Cantidad = 3 },
                new TraspasoDetalle { Id = 11, IdTraspaso = 3, IdProducto = 108, Cantidad = 2 },
                new TraspasoDetalle { Id = 12, IdTraspaso = 3, IdProducto = 102, Cantidad = 4 },
                new TraspasoDetalle { Id = 13, IdTraspaso = 4, IdProducto = 101, Cantidad = 2 },
                new TraspasoDetalle { Id = 14, IdTraspaso = 4, IdProducto = 109, Cantidad = 3 },
                new TraspasoDetalle { Id = 15, IdTraspaso = 4, IdProducto = 104, Cantidad = 2 },
                new TraspasoDetalle { Id = 16, IdTraspaso = 4, IdProducto = 107, Cantidad = 4 }
                );
            context.SaveChanges();

            //Recepcion
            context.Recepciones.AddOrUpdate(
                r => r.Id,
                new Recepcion { Id = 1, Factura = 000005, OrdenDeCompra = 1, FechasCreacion = DateTime.Today }
                );
            context.SaveChanges();

            //Metodo de pago
            context.Metodosdepago.AddOrUpdate(
          r => r.Id,
          new MetodoPago { Id = 1, MetododePago=" Efectivo" },
          new MetodoPago { Id = 2, MetododePago = " Debito" }
          
          );
            context.SaveChanges();


        }
    }
}
