using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratasExemplo
{
    /* Todo método abstrato somos obrigado
     * a reescrevê-lo caso herdemos da classe
     */
    class Corrente : Conta
    {
        public override void Creditar(double valor)
        {   /*
             * Base é equivalente ao this.
             * Porém normalmente usamos base
             * quando nos referimos a um atributo
             * de uma classe pai que herdamos
             */
            base.saldo = valor;
        }
    }
}
