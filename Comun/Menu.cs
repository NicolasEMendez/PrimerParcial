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

        /// <summary>
        /// Imprime a la consola todos los items del Menu.
        /// </summary>
        public void ImprimirALaConsola()
        {
            Console.Clear();
            Console.WriteLine(Descripcion);
            Console.WriteLine("");

            foreach (var menu in MenuItems)
            {
                Console.WriteLine(MenuItems.IndexOf(menu) + 1 + " : " + menu.Descripcion);
            }

            Console.WriteLine("");
        }
    }
}
