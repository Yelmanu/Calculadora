using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Servicios
{
    /// <summary>
    /// Interfaz que corresponde a las operaciones a realizar en la calculadora
    /// </summary>
    internal interface OperacionesInterfaz
    {
        /// <summary>
        /// Realiza la suma indicada por el usuario
        /// 091023 - MDN
        /// </summary>
        /// <returns></returns>
        public int suma();

        /// <summary>
        /// Realiza la resta indicada por el usuario
        /// 091023 - MDN
        /// </summary>
        /// <returns></returns>
        public int resta();

        /// <summary>
        /// Realiza la multiplicación indicada por el usuario
        /// 091023 - MDN
        /// </summary>
        /// <returns></returns>
        public int multiplicacion();

        /// <summary>
        /// Realiza la división indicada por el usuario
        /// 091023 - MDN
        /// </summary>
        /// <returns></returns>
        public double division();

    }
}
