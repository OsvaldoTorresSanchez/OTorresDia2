using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialR
{
     class Program
    {
        public static void Factorial( int numero)
        {

            int resultado = 1;

            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }

            Console.WriteLine("El resultado: " + resultado);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese un número");
            numero = int.Parse(Console.ReadLine());

            Factorial(numero);

            Console.WriteLine();


        }
    }
}
