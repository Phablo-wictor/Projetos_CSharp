using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula_Classes_Staticas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Matematica.taxa = 10;

            int valor1 = Matematica.Adicionar(200);
            int valor2 = Matematica.Diminuir(200);

            Console.WriteLine("Valor1 "+ valor1);
            Console.WriteLine("Valor2 " + valor2);
        }
    }
}
