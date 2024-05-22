using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiro_contato.PessoaCopia // O namespace é como se fosse o endereço da sua classe para utilizar no program principal é necessário utilizar o using
{
    public class Pessoa
    {
        public string Nome {get; set;}
        public int Idade {get; set;}

        public void apresentar()
        {
            Console.WriteLine($"meu nome é {Nome} e eu tenho {Idade} anos");
        }
    }
}