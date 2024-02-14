using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heranca
{
    abstract class Veiculo
    {
        public string Cor { get; set; }

        public string Marca { get; set; }


        public abstract void Acelerar();

        public void Para()
        {
            Console.WriteLine("Parou");
        }


    }
}
