using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trab_Indiv_1
{
    class PessoaJuridica : Pessoa
    {
        public string Ie { get; set; }
        public string Cnpj { get; set; }
        public Endereco endereco { get; set; }
    }
}
