using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
     class Program
    {
        public void Saludo()
        {
            Console.WriteLine("Hola Mundo");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Saludo();
            Console.ReadKey();

            //Para invocar un metodo
            // 1- Mediante un objeto
            // 2- Poniendo static al metodo
        }
    }
}
