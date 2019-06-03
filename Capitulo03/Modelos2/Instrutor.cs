
using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo03.Modelos2
{
    class Instrutor : Funcionario
    {
        public string Especialidade { get; set; }

        public Instrutor (string CPF, string nome, float salario, string especialidade) : base(CPF, nome, salario)
        {
            Especialidade = especialidade;
        }
    }
}
