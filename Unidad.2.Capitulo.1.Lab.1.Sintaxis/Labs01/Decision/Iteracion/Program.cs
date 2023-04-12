using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteracion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] palabras = new string[5];
            int cantIteraciones = 5;
            for (int i=0; i< cantIteraciones; i++)
            {
                Console.WriteLine("INGRESE UNA PALABRA PARA LA POSICION " + (i+1));
                palabras[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("POSICION     PALABRA");

            for(int i=cantIteraciones-1; i >= 0; i--)
            {
                Console.WriteLine((i+1) + "             " + palabras[i]);
            }

            Console.WriteLine();
            Console.WriteLine("PULSE UNA TECLA PARA FINALIZAR EL PROGRAMA...");
            Console.ReadKey();
        }
    }
}
