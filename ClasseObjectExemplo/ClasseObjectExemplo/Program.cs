using System;

namespace ClasseObjectExemplo
{
    class Program
    {
        /* Programa feito com intuito de testar
         * as funcionalidades da classe Object
         * Como sobrescrever o retorno de .ToString
         */
        static void Main(string[] args)
        {
            Computador comp = new Computador();

            Console.WriteLine(comp.ToString());
        }
    }
}
