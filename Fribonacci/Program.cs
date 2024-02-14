using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace Fribonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0;

            Console.WriteLine("Consutes os valores");
            int valores = int.Parse(Console.ReadLine());

            Console.WriteLine("Sequencia de Fibanocci" + valores + " valores");

            for (int i = 0; i < valores; i++)
            {
                if ( i < valores - 1)
                {

                    Console.WriteLine (a + ", ");

                }
                else
                {
                    Console.WriteLine(a);

                }

                c = a + b;
                a = b;
                b = c;

            }

            Console.ReadKey();
        }
    }
}
