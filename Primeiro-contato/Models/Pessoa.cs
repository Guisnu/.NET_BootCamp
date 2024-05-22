using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiro_contato.Models
{
    public class Pessoa
    {
        public string Nome {get; set;}
        public int Idade {get; set;}

        public void apresentar()
        {
            Console.WriteLine($"meu nome é {Nome} e eu tenho {Idade} anos");
            // Console.WriteLine($"meu nome é {Nome} \n e eu tenho {Idade} anos");
        }
    }
}