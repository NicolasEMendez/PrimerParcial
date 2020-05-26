using Comun;
using Comun.Dominio;
using System;
using System.Collections.Generic;

namespace Servicios
{
    public class ProductoService
    {
        private CargaDatosService cargaDatosService;

        public List<Producto> Productos;

        public ProductoService()
        {
            Productos = new List<Producto>();

            cargaDatosService = new CargaDatosService(Productos);

            cargaDatosService.CargaProductosInicial(ref Productos);
        }

        public void MostrarProductos()
        {
            foreach (var producto in Productos)
            {
                Console.WriteLine($"Nombre: {producto.NombreProducto}");
                Console.WriteLine($"Categoria: {producto.TipoCategoria.ToString()}");
                Console.WriteLine($"Precio: {producto.Inventario.Precio + "$"}");
                Console.WriteLine($"Stock: {producto.Inventario.Stock}");
                Console.WriteLine($"Cant Vendidas: {producto.Inventario.CantidadVentas}");
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("Presione Cualquier tecla para continuar");
            Console.ReadKey();

            Console.Clear();

        }

        public void MostrarProductos(List<Producto> productos)
        {
            foreach (var producto in productos)
            {
                Console.WriteLine($"Nombre: {producto.NombreProducto}");
                Console.WriteLine($"Categoria: {producto.TipoCategoria.ToString()}");
                Console.WriteLine($"Precio: {producto.Inventario.Precio + "$"}");
                Console.WriteLine($"Stock: {producto.Inventario.Stock}");
                Console.WriteLine($"Cant Vendidas: {producto.Inventario.CantidadVentas}");
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("Presione Cualquier tecla para continuar");
            Console.ReadKey();

            Console.Clear();
        }

        public void Salir()
        {
            Console.Clear();

            Console.WriteLine("Esta Seguro que desea Salir? SI - NO");

            string decision = Console.ReadLine();

            while (decision.ToUpper() != "SI" && decision.ToUpper() != "NO")
            {
                Salir();
            }

            if (decision.ToUpper() == "SI")
            {
                Environment.Exit(0);
            }
        }

        public void MostrarProductoPorCategoria(TipoCategoria categoria)
        {
            switch (categoria)
            {
                case TipoCategoria.Electricidad:
                    MostrarProductos(Productos.FindAll(x => x.TipoCategoria == categoria));
                    break;
                case TipoCategoria.Construccion:
                    MostrarProductos(Productos.FindAll(x => x.TipoCategoria == categoria));
                    break;
                case TipoCategoria.Plomeria:
                    MostrarProductos(Productos.FindAll(x => x.TipoCategoria == categoria));
                    break;
                case TipoCategoria.Herramientas:
                    MostrarProductos(Productos.FindAll(x => x.TipoCategoria == categoria));
                    break;
                default:
                    MostrarProductos();
                    break;
            }
        }

        public void MostrarProductoSegunStock(SegunStock stockSeleccion)
        {
            switch (stockSeleccion)
            {
                case SegunStock.SinStock:
                    MostrarProductos(Productos.FindAll(x => x.Inventario.Stock == 0));
                    break;
                case SegunStock.ConStockMenorCien:
                    MostrarProductos(Productos.FindAll(x => x.Inventario.Stock < 100));
                    break;
                case SegunStock.ConStockMayorCien:
                    MostrarProductos(Productos.FindAll(x => x.Inventario.Stock > 100));
                    break;
                default:
                    break;
            }
        }
    }
}




