using System;
using System.Collections.Generic;
using System.Linq;

namespace Comun
{
    public class ColeccionMenu
    {
        public ColeccionMenu()
        {
            Menus = new List<Menu>();
        }

        public List<Menu> Menus { get; set; }

        public void AdherirMenu(Menu menu)
        {
            Menus.Add(menu);
        }

        public void MostrarMenu(int id)
        {
            var menuPresente = Menus.Where(m => m.MenuId == id)
                .Single();

            menuPresente.ImprimirALaConsola();

            Console.WriteLine($"Seleccione una opcion");
            string opcionSeleccionada = Console.ReadLine();

            int indiceOpcion;

            if (!int.TryParse(opcionSeleccionada, out indiceOpcion) || indiceOpcion < 0 || indiceOpcion > menuPresente.MenuItems.Count)
            {
                Console.Clear();

                Console.WriteLine("Seleccion Invalida. Intentelo nuevamente");
                MostrarMenu(id);
            }
            else
            {
                var menuItemSeleccionado = menuPresente.MenuItems[indiceOpcion - 1];

                Console.Clear();

                menuItemSeleccionado.Accion?.Invoke();

                MostrarMenu(menuItemSeleccionado.SubMenuId.Value);
            }
        }

    }
}
