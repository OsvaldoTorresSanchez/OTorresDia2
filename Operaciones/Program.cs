using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
     class Program
    {
        public static void Operaciones( int numero1, int numero2)
        {
            int suma, resta, multiplicacion, divicion;

            Console.WriteLine("---- Operaciones matematicas ----"); // Mensale en consola

            //Resultado
            suma = numero1 + numero2;
            Console.WriteLine("\n El resultado de la suma es: " + suma); // Mensale en consola

            resta = numero1 - numero2;
            Console.WriteLine("\n El resultado de la resta es: " + resta); // Mensale en consola

            multiplicacion = numero1 * numero2;
            Console.WriteLine("\n El resultado de la multiplicacion es: " + multiplicacion); // Mensale en consola

            divicion = numero1 / numero2;
            Console.WriteLine("\n El resultado de la multiplicacion es: " + divicion); // Mensale en consola

            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            int numero1, numero2 
                ;
            Console.WriteLine("\n Ingrese el primer numero: "); // Mensale en consola
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Ingrese el segundo numero: "); // Mensale en consola
            numero2 = int.Parse(Console.ReadLine());

            Operaciones(numero1, numero2);

            Console.WriteLine();
        }
    }
}
