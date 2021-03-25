using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenasEjercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            string primerTexto = "";
            string segundoTexto = "";

            do
            {
                Console.WriteLine("Ingrese el primer texto");
                primerTexto = Console.ReadLine().ToUpper();
                if (primerTexto == "")
                {
                    Console.WriteLine("No puede ser vacío");
                }
            } while (primerTexto == "");

            do
            {
                Console.WriteLine("Ingrese el segundo texto");
                segundoTexto = Console.ReadLine().ToUpper();
                if (primerTexto == "")
                {
                    Console.WriteLine("No puede ser vacío");
                }
            } while (segundoTexto == "");


            if (primerTexto.Equals(segundoTexto))
            {
                Console.WriteLine("Los textos son iguales");
            }
            else
            {
                Console.WriteLine("Los textos no son iguales");
            }

            Console.ReadKey();
        }
    }
}
