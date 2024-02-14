using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ProjetoFrameworkdotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz1 = new int[3, 3];
            int[,] matriz2 = new int[3, 3];
            int[,] resutado = new int[3, 3];

            Console.WriteLine("Matriz1");

            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.WriteLine("#1. posição [" + linha + "][" + coluna + "]:");
                    matriz1[linha, coluna] = int.Parse(Console.ReadLine());

                }

            }
            Console.WriteLine("Matriz2");

            for (int linha1 = 0; linha1 < 2; linha1++)
            {
                for (int coluna2 = 0; coluna2 < 3; coluna2++){

                        Console.WriteLine("#1. posição [" + linha1 + "][" + coluna2 + "]:");
                        matriz1[linha1, coluna2] = int.Parse(Console.ReadLine());

                    }
            }


            Console.WriteLine("\n Resustado de Matriz #1 X Matriz #2");

            resutado[0, 0] = (matriz1[0, 0] * matriz2[0, 0]) + (matriz1[0, 1] * matriz2[1, 0]) + (matriz1[0, 2] * matriz2[2, 0]);
            resutado[1, 0] = (matriz1[1, 0] * matriz2[0, 0]) + (matriz1[1, 1] * matriz2[1, 0]) + (matriz1[1, 2] * matriz2[2, 0]);
            resutado[0, 1] = (matriz1[0, 0] * matriz2[0, 1]) + (matriz1[0, 1] * matriz2[1, 1]) + (matriz1[0, 2] * matriz2[2, 1]);
            resutado[1, 1] = (matriz1[1, 0] * matriz2[0, 1]) + (matriz1[1, 1] * matriz2[1, 1]) + (matriz1[1, 2] * matriz2[2, 1]);

            Console.WriteLine("[" + resutado[0, 0] + "][" + resutado[0, 1] + "]");
            Console.WriteLine("[" + resutado[1, 0] + "][" + resutado[1, 1] + "]");

            Console.ReadKey();


        }
    }
}
