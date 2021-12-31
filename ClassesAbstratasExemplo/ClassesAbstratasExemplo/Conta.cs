using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratasExemplo
{
    public abstract class Conta // Declarar que a conta é abstrata
    {
        protected double saldo; // somente a propria classe ou classes filhas podem acessá-la

        public abstract void Creditar(double valor); // Não tem implementação por ser um método abstrato

        public void ExibirSaldo()
        {
            Console.WriteLine($"O valor do seu saldo é de R$ {saldo}");
        }
    }
}
