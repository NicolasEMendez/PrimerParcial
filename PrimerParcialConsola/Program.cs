using Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            CreadorMenu creadorMenu = new CreadorMenu();
            ColeccionMenu coleccionMenu = creadorMenu.CrearCollecionMenu();

            coleccionMenu.MostrarMenu(1);

            Console.ReadKey();
        }
    }
}
