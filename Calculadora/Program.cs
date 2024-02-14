using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Inicio:

            Console.Clear();

            Console.WriteLine("Digite o primeiro numero: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma operação (+ - x /): ");
            char op = char.Parse(Console.ReadLine());

            double resultado;

            switch (op)
            {
                default:
                    Console.WriteLine("Opção Iválida");
                    goto Inicio;

                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine("O resultado dsa soma é "+ resultado);

                    break;
                case '-':
                     resultado = num1 - num2;
                     Console.WriteLine("O resultado da subtração é " + resultado);

                    break;
                case 'x':
                    resultado = num1 * num2;
                    Console.WriteLine("O resulatdo da multiplicação é " + resultado);

                    break;
                case '/':
                    if (num2 == 0)
                    {
                    Console.WriteLine("Não é possivel divi por 0");
                    }
                    else
                    {
                    resultado = num1 / num2;
                    Console.WriteLine("O resulatdo da divisão é " + resultado);

                    }

                    break;
            }

            Console.WriteLine("Continuar Caculando (S / N)");
            String opcao = Console.ReadLine();

            if (opcao == "S" || opcao == "s")
            {
                goto Inicio;
            }
            

        }
    }
}
