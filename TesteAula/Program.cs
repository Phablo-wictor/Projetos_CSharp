using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesteAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informte peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Informte Altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double valorIMC = peso / (altura * altura);

            if (valorIMC < 20){
                Console.WriteLine("\nIMC = " + valorIMC + " --> Abaixo do peso");

            } else if (valorIMC >= 20 && valorIMC <= 24){
                Console.WriteLine("\n IMC = " + valorIMC + " --> Peso ideal");

            } else if (valorIMC >= 25 && valorIMC <= 29 ){
                Console.WriteLine("\nIMC = " + valorIMC + " --> Acima do Peso");

            } else if (valorIMC >= 30 && valorIMC <= 24){
                Console.WriteLine("\nIMC = " + valorIMC + " --> Obeso");
            }
            else
            {
                Console.WriteLine("\nIMC = " + valorIMC + "--> Muito Obeso");

            }
        }
    }
}
