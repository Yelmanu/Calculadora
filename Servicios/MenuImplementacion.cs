using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenu()
        {
            int opcionSeleccionada;

            Console.WriteLine("\n1.- Cerrar");
            Console.WriteLine("2.- Suma");
            Console.WriteLine("3.- Resta");
            Console.WriteLine("4.- Multiplicación");
            Console.WriteLine("5.- División");
            Console.WriteLine("Elija una opción");
            opcionSeleccionada=Console.ReadKey(true).KeyChar - ('0');
            return opcionSeleccionada;
        }
    }
}
