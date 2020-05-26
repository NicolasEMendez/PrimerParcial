using Comun;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialConsola
{
    public class CreadorMenu
    {
        private ProductoService productoService;
        private ColeccionMenu coleccionMenu;

        public CreadorMenu()
        {
            productoService = new ProductoService();
            coleccionMenu = new ColeccionMenu();
        }

        public ColeccionMenu CrearCollecionMenu()
        {
            coleccionMenu = new ColeccionMenu()
            {
                Menus =
                {
                    CrearMenuPrincipal(),
                    CrearSubMenuMostrarProducto(),
                    CrearSubMenuCategoria(),
                    CrearSubMenuSegunStock()
                }
            };

            return coleccionMenu;
        }

      
        private Menu CrearMenuPrincipal()
        {
            return new Menu()
            {
                MenuId = 1,
                Descripcion = "MENU PRINCIPAL",
                MenuItems =
                {
                    new MenuItem()
                    {
                        Descripcion = "Mostrar Productos",
                        SubMenuId = 2
                    },
                    new MenuItem()
                    {
                        Descripcion = "Buscar Productos",
                    },
                    new MenuItem()
                    {
                        Descripcion = "Agregar nuevo Producto",
                    },
                    new MenuItem()
                    {
                        Descripcion = "Modificar Producto",
                    },
                    new MenuItem()
                    {
                        Descripcion = "Eliminar producto del sistema",
                    },
                    new MenuItem()
                    {
                        Descripcion = "Facturacion",
                    },
                    new MenuItem()
                    {
                        SubMenuId = 1,
                        Descripcion = "Salir",
                        Accion = () => productoService.Salir()
                    }
                }
            };
        }

        private Menu CrearSubMenuMostrarProducto()
        {
            return new Menu()
            {
                MenuId = 2,
                Descripcion = "MOSTRAR PRODUCTOS",
                MenuItems =
                {
                    new MenuItem()
                    {
                        Descripcion = "Mostrar Todos",
                        Accion = () => productoService.MostrarProductos(),
                        SubMenuId = 1
                    },
                    new MenuItem()
                    {
                        Descripcion = "Mostrar Segun Categoria",
                        SubMenuId = 3
                    },
                    new MenuItem()
                    {
                        Descripcion = "Mostrar Segun Stock",
                        SubMenuId = 4
                    },
                    new MenuItem()
                    {
                        Descripcion = "Volver al menu principal",
                        SubMenuId = 1
                    }
                }
            };
        }

        private Menu CrearSubMenuCategoria()
        {
            return new Menu()
            {
                MenuId = 3,
                Descripcion = "CATEGORIAS",
                MenuItems =
                {
                    new MenuItem()
                    {
                        Descripcion = TipoCategoria.Electricidad.ToString(),
                        Accion = () => productoService.MostrarProductoPorCategoria(TipoCategoria.Electricidad),
                        SubMenuId = 1
                    },
                    new MenuItem()
                    {
                        Descripcion = TipoCategoria.Construccion.ToString(),
                        Accion = () => productoService.MostrarProductoPorCategoria(TipoCategoria.Construccion),
                        SubMenuId = 1
                    },
                    new MenuItem()
                    {
                        Descripcion = TipoCategoria.Plomeria.ToString(),
                        Accion = () => productoService.MostrarProductoPorCategoria(TipoCategoria.Plomeria),
                        SubMenuId = 1
                    },
                    new MenuItem()
                    {
                        Descripcion = TipoCategoria.Herramientas.ToString(),
                        Accion = () => productoService.MostrarProductoPorCategoria(TipoCategoria.Herramientas),
                        SubMenuId = 1
                    },
                    new MenuItem()
                    {
                        Descripcion = "Volver al menu principal",
                        SubMenuId = 1
                    }
                }
            };
        }

        private Menu CrearSubMenuSegunStock()
        {
            return new Menu()
            {
                MenuId = 4,
                Descripcion = "PRODUCTOS SEGUN STOCK",
                MenuItems =
                {
                    new MenuItem()
                    {
                        Descripcion = "Mostrar Productos sin Stock",
                        Accion = () => productoService.MostrarProductoSegunStock(SegunStock.SinStock),
                        SubMenuId = 1
                    },
                    new MenuItem()
                    {
                        Descripcion = "Mostrar Productos con Stock menor a 100",
                        Accion = () => productoService.MostrarProductoSegunStock(SegunStock.ConStockMenorCien),
                        SubMenuId = 1
                    },
                    new MenuItem()
                    {
                        Descripcion = "Mostrar Productos con Stock mayor a 100",
                        Accion = () => productoService.MostrarProductoSegunStock(SegunStock.ConStockMayorCien),
                        SubMenuId = 1
                    },
                    new MenuItem()
                    {
                        Descripcion = "Volver al menu principal",
                        SubMenuId = 1
                    }
                }
            };
        }


    }
}
