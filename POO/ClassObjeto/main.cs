using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassObjeto
{
     class main
    {
        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa();

            p1.nome         = "Phablo";
            p1.sobremones   = "Moura";
            p1.anoNacimento = 2003;


            Pessoa p2 = new Pessoa()
            {
                nome         = "Gabriela",
                sobremones   = "lima",
                anoNacimento = 1999,
               
            };

            Console.WriteLine("Pessoa 1: " + p1.nome + " " + p1.sobremones + " | Ano de Nacimento: " + p1.anoNacimento);

            Console.WriteLine("Pessoa 2: " + p2.nome + " " + p2.sobremones + " | Ano de Nacimento: " + p2.anoNacimento);


        }

    }
}
