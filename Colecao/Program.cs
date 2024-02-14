using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numero = new int[5];

            numero[0] = 10;
            numero[1] = 20;
            numero[2] = 30;
            numero[3] = 40;
            numero[4] = 50;

            numero[2] = 55;

            string[] nomes = {
                "Phablo",
                "Wictor",
                "Lima",
                "Moura",
            };

            //Console.WriteLine(numero[2]);
            //Console.WriteLine(nomes[0]);
            //Console.ReadLine();

            string[,] nome =
            {
                { "Nomes", "Idade","Altura" },
                {"Phablo", "19", "1.60" }

            };

            Console.WriteLine( "[" + nome[0, 0] + "][" + nome[0,1] + "]["+ nome[0,2] + "]");

            Console.WriteLine( "[" + nome[1, 0] + "][" + nome[1, 1] + "][" + nome[1 ,2] + "]");
           

            Console.ReadLine();




        }
    }
}
