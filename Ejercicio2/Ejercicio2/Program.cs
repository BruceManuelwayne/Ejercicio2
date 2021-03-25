using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un texto");

            string texto = Console.ReadLine();

            while (string.IsNullOrEmpty(texto))
            {
                Console.WriteLine("Por favor ingrese un texto");
                texto = Console.ReadLine(); 
            }

            Console.WriteLine($"El texto ingresado es {texto}");
            Console.ReadKey(); 



        }
    }
}
