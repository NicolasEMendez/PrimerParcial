using Comun;
using Comun.Dominio;
using System.Collections.Generic;

namespace Servicios
{
    public class CargaDatosService
    {
        public CargaDatosService(List<Producto> productos)
        {
            CargaProductosInicial(ref productos);
        }

        public void CargaProducto(ref List<Producto> productos, Producto productoNuevo)
        {
            productos.Add(productoNuevo);
        }

        public List<Producto> CargaProductosInicial(ref List<Producto> productos)
        {
            Producto producto = new Producto()
            {
                TipoCategoria = TipoCategoria.Construccion,
                NombreProducto = "Ladrillo",
                Inventario = new Inventario()
                {
                    Precio = 80,
                    Stock = 120,
                    CantidadVentas = 50
                },
                Facturacion = new Facturacion()
                {
                    GananciaProducto = 0
                }
            };

            producto.SetearIdProducto(12);

            productos.Add(producto);

            producto = new Producto()
            {
                TipoCategoria = TipoCategoria.Electricidad,
                NombreProducto = "Bombillas",
                Inventario = new Inventario()
                {
                    Precio = 20,
                    Stock = 300,
                    CantidadVentas = 100
                },
                Facturacion = new Facturacion()
                {
                    GananciaProducto = 0
                }
            };

            producto.SetearIdProducto(4);

            productos.Add(producto);

            producto = new Producto()
            {
                TipoCategoria = TipoCategoria.Herramientas,
                NombreProducto = "Destornillador",
                Inventario = new Inventario()
                {
                    Precio = 95,
                    Stock = 124,
                    CantidadVentas = 13
                },
                Facturacion = new Facturacion()
                {
                    GananciaProducto = 0
                }
            };

            producto.SetearIdProducto(15);

            productos.Add(producto);

            producto = new Producto()
            {
                TipoCategoria = TipoCategoria.Plomeria,
                NombreProducto = "Caños de Agua",
                Inventario = new Inventario()
                {
                    Precio = 100,
                    Stock = 0,
                    CantidadVentas = 500
                },
                Facturacion = new Facturacion()
                {
                    GananciaProducto = 0
                }
            };

            producto.SetearIdProducto(1);

            productos.Add(producto);

            producto = new Producto()
            {
                TipoCategoria = TipoCategoria.Herramientas,
                NombreProducto = "Pinza",
                Inventario = new Inventario()
                {
                    Precio = 135,
                    Stock = 80,
                    CantidadVentas = 25
                },
                Facturacion = new Facturacion()
                {
                    GananciaProducto = 0
                }
            };

            producto.SetearIdProducto(9);

            productos.Add(producto);

            producto = new Producto()
            {
                TipoCategoria = TipoCategoria.Construccion,
                NombreProducto = "Bolsa Arena",
                Inventario = new Inventario()
                {
                    Precio = 60,
                    Stock = 45,
                    CantidadVentas = 1500
                },
                Facturacion = new Facturacion()
                {
                    GananciaProducto = 0
                }
            };

            producto.SetearIdProducto(90);

            productos.Add(producto);

            producto = new Producto()
            {
                TipoCategoria = TipoCategoria.Plomeria,
                NombreProducto = "Flexible Caño",
                Inventario = new Inventario()
                {
                    Precio = 100,
                    Stock = 5,
                    CantidadVentas = 495
                },
                Facturacion = new Facturacion()
                {
                    GananciaProducto = 0
                }
            };

            producto.SetearIdProducto(10);

            productos.Add(producto);

            producto = new Producto()
            {
                TipoCategoria = TipoCategoria.Herramientas,
                NombreProducto = "Martillo",
                Inventario = new Inventario()
                {
                    Precio = 120,
                    Stock = 150,
                    CantidadVentas = 95
                },
                Facturacion = new Facturacion()
                {
                    GananciaProducto = 0
                }
            };

            producto.SetearIdProducto(31);

            productos.Add(producto);

            producto = new Producto()
            {
                TipoCategoria = TipoCategoria.Plomeria,
                NombreProducto = "Canillas",
                Inventario = new Inventario()
                {
                    Precio = 45,
                    Stock = 15,
                    CantidadVentas = 1200
                },
                Facturacion = new Facturacion()
                {
                    GananciaProducto = 0
                }
            };

            producto.SetearIdProducto(11);

            productos.Add(producto);

            producto = new Producto()
            {
                TipoCategoria = TipoCategoria.Electricidad,
                NombreProducto = "Cable (Por Metro)",
                Inventario = new Inventario()
                {
                    Precio = 50,
                    Stock = 98,
                    CantidadVentas = 300
                },
                Facturacion = new Facturacion()
                {
                    GananciaProducto = 0
                }
            };

            producto.SetearIdProducto(7);

            productos.Add(producto);


            return productos;
        }
    }
}
