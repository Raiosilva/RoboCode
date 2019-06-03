using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo03.Modelos
{
    class Funcionario03 : Pessoa06
    {
        public const float BONIFICACA0_MENSAL = 1000F;

        private float _salario;
        public float Salario
        {
            get
            {
                return _salario;
            }

            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("salario");
                _salario = value;
            }
        }
        public string Cargo { get; set; }
        public Funcionario03(string nome, string sobrenome, string cargo, float salario) : base(nome, sobrenome)
        {
            Console.WriteLine("Construtor ca classe 02");
            Cargo = cargo;
            Salario = salario;
            var str = NomeCompleto;
        }

        public virtual float GetTotalPagar()
        {
            return Salario = BONIFICACA0_MENSAL;
        }
    }
}
