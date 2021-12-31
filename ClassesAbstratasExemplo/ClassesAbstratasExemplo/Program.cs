using System;

namespace ClassesAbstratasExemplo
{
    /* Programa para trabalhar a utilização
     * de classes abstratas de uma conta bancária.
     * Onde é criada uma classe abstrata
     * com atributos protected e dois métodos.
     * Um deles implementado, e o outro apenas abstrato.
     * Cabendo a classe filha, que herdará dessa classe
     * abstrata, implementar o método abstrato
     */
    class Program
    {
        static void Main(string[] args)
        {
            Corrente c = new Corrente();
            c.Creditar(1200.15);
            c.ExibirSaldo();
        }
    }
}
