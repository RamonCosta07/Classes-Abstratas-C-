using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseSeladaExemplo
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, me chamo {Nome} e possuo {Idade} anos");
        }
    }
}
