using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public class Menu
    {
        public Menu()
        {
            MenuItems = new List<MenuItem>();
        }

        public List<MenuItem> MenuItems { get; set; }
        public int MenuId { get; set; }
        public string Descripcion { get; set; }

        public void ImprimirALaConsola()
        {
            Console.WriteLine(Descripcion);
            Console.WriteLine("");

            foreach (var menu in MenuItems)
            {
                Console.WriteLine(MenuItems.IndexOf(menu) + 1 + " : " + menu.Descripcion);
            }

            Console.WriteLine("");
        }

        public Menu CrearMenu(int id, string descripcion, IEnumerable<MenuItem> menuItems)
        {
            Menu menu = new Menu()
            {
                MenuId = id,
                Descripcion = descripcion
            };

            menu.MenuItems.AddRange(MenuItems);

            return menu;
        }

        public Menu CrearMenu(int id, string descripcion, params MenuItem[] menuItems)
        {
            return CrearMenu(id, descripcion, menuItems);
        }
    }
}
