using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_con_CASE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String inputTexto;
            Console.WriteLine("INGRESE UN TEXTO (CASE)");
            Console.WriteLine();
            inputTexto = Console.ReadLine();
            Console.WriteLine();
            if (inputTexto.Length != 0)
            {
                Console.WriteLine("1- Mostrar la frase ingresada en mayúsculas");
                Console.WriteLine("2- Mostrar la frase ingresada en minúsculas");
                Console.WriteLine("3- Contar los caracteres de la frase ingresada");
                Console.WriteLine();
                ConsoleKeyInfo opcion = Console.ReadKey();
                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        Console.WriteLine(inputTexto.ToUpper());
                        Console.WriteLine("pulse cualquier tecla para finalizar el programa...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine();
                        Console.WriteLine(inputTexto.ToLower());
                        Console.WriteLine("pulse cualquier tecla para finalizar el programa...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine();
                        Console.WriteLine("EL TEXTO TIENE ESTA CANTIDAD DE CARACTERES:");
                        Console.WriteLine(inputTexto.Length);
                        Console.WriteLine("pulse cualquier tecla para finalizar el programa...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("NO ELIGIÓ NINGUNA DE LAS OPCIONES ESPERADAS, FIN DE LA APLICACIÓN");
                        Console.WriteLine("pulse cualquier tecla para finalizar el programa...");
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("NO INGRESÓ NINGUN TEXTO, FIN DEL PROGRAMA");
                Console.WriteLine("pulse cualquier tecla para finalizar el programa...");
                Console.ReadKey();
            }
        
        }
    }
}
