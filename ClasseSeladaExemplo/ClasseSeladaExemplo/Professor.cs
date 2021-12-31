using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseSeladaExemplo
{
    public class Professor : Pessoa
    {
        public double salario { get; set; }

        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou professor. Recebo R$ {salario}");
        }
    }
}
