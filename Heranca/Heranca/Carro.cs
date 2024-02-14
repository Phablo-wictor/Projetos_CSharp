using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heranca
{
    internal class Carro : Veiculo
    {

        public override void Acelerar()
        {
            Console.WriteLine("o carro acelerou!");
        }

        public int ValecidadeMaxima {get;set;}

        public void ligarMotor()
        {
            Console.WriteLine("O carro ligou o motor");
        }

        
    }
}
