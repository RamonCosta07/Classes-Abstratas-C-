using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseSeladaExemplo
{
    class Diretor : Professor
    {
        /* Não vamos conseguir sobrescrever o método
         * Pois ele foi marcado como "Sealed" na classe pai
         */
        //public override void Apresentar()
        //{
        //    Console.WriteLine($"Olá, meu nome é {Nome} e sou diretor. Recebo R$ {salario}");
        //}
    }
}
