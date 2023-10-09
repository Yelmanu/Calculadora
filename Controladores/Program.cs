using Calculadora.Servicios;

namespace Calculadora
{
    /// <summary>
    /// Clase que controla el flujo de procedimientos de la aplicación
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada de la aplicación
        /// Contiene el procedimiento de la aplicación
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Instanciamos la clase que contiene los métodos de la aplicación
            MenuInterfaz menuCalculadora = new MenuImplementacion();
            OperacionesInterfaz operacionesCalculadora = new OperacionesImplementacion();

            //Creamos una variable bool y una variable int para el menu (bool para el control
            //de flujo while e int para capturar la opcion introducida por el usuario)
            bool cerrarMenu = false;
            int opcionIntroducida;

            //Bucle while para controlar cuando se cierra el menu
            while (!cerrarMenu)
            {
                opcionIntroducida = menuCalculadora.mostrarMenu();
                Console.WriteLine("[INFO] Has seleccionada la opción {0}", opcionIntroducida);

                switch( opcionIntroducida ) 
                {
                    case 1:
                        Console.WriteLine("[INFO] Se cerrará la aplicación");
                        cerrarMenu = true;
                        break;
                    case 2:
                        operacionesCalculadora.suma();
                        break;
                    case 3:
                        operacionesCalculadora.resta();
                        break;
                    case 4:
                        operacionesCalculadora.multiplicacion();
                        break;
                    case 5:
                        operacionesCalculadora.division();
                        break;
                    default:
                        Console.WriteLine("[INFO] La opción seleccionada no existe");
                        break;
                }
            }
        }
    }
}