using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo03.Modelos
{
    class Vendedor : Funcionario03
    {
        public Vendedor(string nome, string sobrenome, string cargo, float salario)
            : base(nome, sobrenome, cargo, salario)
        {


        }
        public override float GetTotalPagar()
        {
            return Salario = BONIFICACA0_MENSAL;

        }
    }
}
