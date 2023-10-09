using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Servicios
{
    internal class OperacionesImplementacion : OperacionesInterfaz
    {
        public int suma()
        {
            Console.WriteLine("Introduce el primer operando: ");
            int primerNumero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo operando: ");
            int segundoNumero = Int32.Parse(Console.ReadLine());
            int suma = primerNumero + segundoNumero;
            Console.WriteLine("La suma es: {0}", suma);

            return suma;
        }

        public int resta() 
        {
            Console.WriteLine("Introduce el primer operando: ");
            int primerNumero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo operando: ");
            int segundoNumero = Int32.Parse(Console.ReadLine());
            int resta = primerNumero - segundoNumero;
            Console.WriteLine("La resta es: {0}", resta);

            return resta;
        }

        public int multiplicacion()
        {
            Console.WriteLine("Introduce el primer operando: ");
            int primerNumero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo operando: ");
            int segundoNumero = Int32.Parse(Console.ReadLine());
            int multiplicacion = primerNumero * segundoNumero;
            Console.WriteLine("La multiplicación es: {0}", multiplicacion);

            return multiplicacion;
        }

        public double division()
        {
            Console.WriteLine("Introduce el primer operando: ");
            int primerNumero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo operando: ");
            int segundoNumero = Int32.Parse(Console.ReadLine());
            double division = primerNumero / segundoNumero;
            Console.WriteLine("La division es: {0}", division);

            return division;
        }
    }
}
