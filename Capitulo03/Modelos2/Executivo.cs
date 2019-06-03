
using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo03.Modelos2
{
    class Executivo : Funcionario
    {
        public float Bonus { get; set; }

        public Executivo(string CPF, string nome, float salario, float bonus) : base(CPF, nome, salario)
        {
            Bonus = bonus;
        }
    }
}
