using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja Bem-Vindo ao Quiz\nTerma: Sonic ");

            Console.WriteLine("Qual Foi o Primeiro Jogo Oficial Do Sonic?");
            Console.WriteLine("1. Sonic the Hedgehog 1991\n2. Sonic Heroes 2003\n3. Sonic Adventure\n4. Sonic colors");
            int res = int.Parse(Console.ReadLine());

            int acertos = 0;
            int erros = 0;

            switch (res)
            {
                case 1:
                    Console.WriteLine("Resposta CERTA! ");
                    acertos =+ 1;

                break;

                case 2:
                    Console.WriteLine("Resposta ERRADA! ");
                    erros += 1;

                break;

                case 3:
                    Console.WriteLine("Resposta ERRADA! ");
                    erros += 1;

                break;

                case 4:
                    Console.WriteLine("Respota ERRADA");
                    erros += 1;

                break;

            }

            Console.WriteLine("Qual foi o Primeiro jogo do sonic multiplataforma?");
            Console.WriteLine("1. Sonic the Hedgehog 2006\n2. Sonic Adventure DX\n3. Sonic generations\n4. Sonic Heroes");
            int res1 = int.Parse(Console.ReadLine());

            switch (res1)
            {
                case 1:
                    Console.WriteLine("Resposta ERRADA!");
                    erros += 1;

                break;

                case 2:
                    Console.WriteLine("Resposta ERRADA");
                    erros += 1;

                break;

                case 3:
                    Console.WriteLine("Resposta ERRADA");
                    erros += 1;
                break;

                case 4:
                    Console.WriteLine("Resposta CERTA!");
                    acertos += 1;
                break;


            }

            Console.WriteLine("Voce Acertou: " + acertos + "x e Errou "+ erros + "x");

        }
    }
}
