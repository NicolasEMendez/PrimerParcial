using Comun;
using Comun.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

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

        /// <summary>
        /// Muestra los productos
        /// </summary>
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

        /// <summary>
        /// Muestra los productos pasandole una lista de productos a mostrar
        /// </summary>
        /// <param name="productos"></param>
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

        /// <summary>
        /// Pregunta si quiere salir del programa con Si o No
        /// </summary>
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

        /// <summary>
        /// Muestra los productos segun la categoria seleccionada
        /// </summary>
        /// <param name="categoria">La categoria seleccionada</param>
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

        /// <summary>
        /// Muestra los productos segun el stock seleccionado
        /// </summary>
        /// <param name="stockSeleccion">La opcion de stock seleccionada</param>
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

        /// <summary>
        /// Busca y muestra el producto mas vendido
        /// </summary>
        public void ProductoMasVendido()
        {
            var productoMasVendido = Productos
                .OrderByDescending(p => p.Inventario.CantidadVentas)
                .FirstOrDefault();

            List<Producto> prods = new List<Producto>()
            {
                productoMasVendido
            };

            MostrarProductos(prods);
        }

        /// <summary>
        /// Busca el producto por nombre
        /// </summary>
        public void BuscarProdPorNombre()
        {
            Console.WriteLine("Por Favor elija el nombre del producto");

            string seleccion = Console.ReadLine();

            if(string.IsNullOrEmpty(seleccion))
            {
                Console.WriteLine("No debe ser vacio, presione cualquier tecla para continuar");

                Console.ReadKey();

                Console.Clear();

                BuscarProdPorNombre();
            }

            var prodPorNombre = Productos
                .Where(p => p.NombreProducto.ToUpper() == seleccion.ToUpper())
                .FirstOrDefault();

            List<Producto> prdBusqueda = new List<Producto>()
            {
                prodPorNombre
            };

            Console.Clear();

            MostrarProductos(prdBusqueda);
        }

        /// <summary>
        /// Busca el producto por Id
        /// </summary>
        public void BuscarProdPorId()
        {
            Console.WriteLine("Por Favor elija el id del producto");

            string seleccion = Console.ReadLine();

            if (!int.TryParse(seleccion, out int seleccionInt))
            {
                Console.WriteLine("Debe ser un Id numerico, presione cualquier tecla para continuar");

                Console.ReadKey();

                Console.Clear();

                BuscarProdPorId();
            }

            var prodPorId = Productos
                .Where(p => p.IdProducto == seleccionInt)
                .FirstOrDefault();

            List<Producto> prdBusqueda = new List<Producto>()
            {
                prodPorId
            };

            Console.Clear();

            MostrarProductos(prdBusqueda);
        }


        //TODO: Falta terminar la implementacion de este metodo
        /// <summary>
        /// Crea el producto
        /// </summary>
        public void CrearProducto()
        {
            Producto nuevoProducto = new Producto();
            KeyValuePair<int, bool> esValidoNumero = new KeyValuePair<int, bool>(0, true);
            bool idRepetido = false;

            PedirIdProducto(nuevoProducto, ref esValidoNumero, ref idRepetido);

            Console.Clear();

            Console.WriteLine("SELECCIONE LA CATEGORIA");
            Console.WriteLine($"1: {TipoCategoria.Construccion}");
            Console.WriteLine($"2: {TipoCategoria.Electricidad}");
            Console.WriteLine($"3: {TipoCategoria.Herramientas}");
            Console.WriteLine($"3: {TipoCategoria.Plomeria}");

            Console.WriteLine("");
            Console.WriteLine("Por favor, seleccione la categoria");

            string catSeleccionada = Console.ReadLine();




        }

        /// <summary>
        /// Pide el id del producto
        /// </summary>
        /// <param name="nuevoProducto">Es el producto a crear</param>
        /// <param name="esValidoNumero">un KeyValuePair de tipo int bool donde guarda el entero id y si es numerico o no</param>
        /// <param name="idRepetido">bool que guarda si el id es repetido</param>
        private void PedirIdProducto(Producto nuevoProducto, ref KeyValuePair<int, bool> esValidoNumero, ref bool idRepetido)
        {
            do
            {
                Console.WriteLine($"Por favor, indique el Id del producto {(esValidoNumero.Value == true ? ", recuerde que debe ser numerico y no debe ser repetido" : string.Empty)}");

                string idSeleccionado = Console.ReadLine();

                esValidoNumero = ValidarNumerico(idSeleccionado);

                if (esValidoNumero.Value)
                {
                    idRepetido = ValidarIdNoRepetirdo(esValidoNumero.Key);
                }

            } while (esValidoNumero.Value == false || idRepetido == false);

            nuevoProducto.IdProducto = esValidoNumero.Key;
        }

        /// <summary>
        /// Valida si lo que escribio el usuario es numerico
        /// </summary>
        /// <param name="idSeleccionado">el numero seleccionado por el usuario</param>
        /// <returns></returns>
        private KeyValuePair<int, bool> ValidarNumerico(string idSeleccionado)
        {
            if(!int.TryParse(idSeleccionado,out int idNumerico))
            {
                return new KeyValuePair<int, bool>(idNumerico, false);
            }

            return new KeyValuePair<int, bool>(idNumerico, true);
        }

        /// <summary>
        /// Valida si el Id es repetido
        /// </summary>
        /// <param name="idNumerico">El numero que el usuario ha tipeado</param>
        /// <returns></returns>
        private bool ValidarIdNoRepetirdo(int idNumerico)
        {
            bool yaExiste = Productos.Exists(x => x.IdProducto == idNumerico);

            if (yaExiste)
            {
                return false;
            }

            return true;
        }
    }
}




