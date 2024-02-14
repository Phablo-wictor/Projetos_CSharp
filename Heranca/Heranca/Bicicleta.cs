using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heranca
{
    internal class Bicicleta : Veiculo
    {

        public override void Acelerar()
        {
            Console.WriteLine("A bicicleta acelerou!");
        }

        public void pedalar()
        {

        }
        
    }
}
