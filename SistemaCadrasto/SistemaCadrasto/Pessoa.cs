using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaCadrasto
{
    class Pessoa
    {

        public string Nome { get; set; }
        public string DataNacimento { get; set; }
        public string EstadoCivil { get; set; }
        public string Telefone { get; set; }
        public bool CasaPropria { get; set; }
        public bool Veiculo { get; set; }
        public char Sexo { set; get; }

    }
}
