using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Servicios
{
    /// <summary>
    /// Interfaz que corresponde a la funcionalidad del menú de la aplicación
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Muestra el menú de la aplicación
        /// 091023 - MDN
        /// </summary>
        /// <returns></returns>
        public int mostrarMenu();
    }
}
