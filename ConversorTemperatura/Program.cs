using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConversorTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double c, f, k;

            Console.WriteLine("### Conversor de termperatura");
            Console.Write("Insira a temperatura em Celcius:");
            c = double.Parse(Console.ReadLine());

            f = (c * 9 / 5) + 32;

            k = c + 273.15;

            Console.WriteLine(c + " Em celcius = " + f + " graus fahranheit");
            Console.WriteLine(c + " Em celcius = " + k + " graus kelvin");

        }
    }
}
