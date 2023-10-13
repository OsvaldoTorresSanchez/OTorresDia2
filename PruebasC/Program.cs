using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PruebasC
{
    internal class Program
    {
        /*
        static void Main(string[] args)
        {

            //Opcion 1
            int altura  = 10,  bases = 10;

            int resul = altura + bases;

            //Console.WriteLine("el resultado es: " + resul) ;
            //Console.ReadKey();

            Console.WriteLine(resul);
            Console.ReadKey();

            // Opcion 2
            /*
                        int num1;
                        int num2;
                        int suma;
                        num1 = 234;
                        num2 = 567;
                        suma = num1 + num2;
                        Console.WriteLine("La suma de {0} y {1} es {2}",
                        num1, num2, suma);
                        Console.ReadKey();

            */
       

        public static int CalcularFactorial(int n)
            {
                
                if (n == 0 || n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * CalcularFactorial(n - 1);
                }
            
        }
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese un número:");
            numero = int.Parse(Console.ReadLine());

            int factorial = CalcularFactorial(numero);
            Console.WriteLine("El factorial de " + numero + " es: " + factorial);

            Console.ReadKey();
        }
    }
}
