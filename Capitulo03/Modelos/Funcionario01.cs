using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo03.Modelos
{
    class Funcionario01 : Pessoa06
    {
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
        public Funcionario01(string nome, string sobrenome, string cargo, float salario) : base(nome, sobrenome)
        {
            Console.WriteLine("Construtor ca classe 02");
            Cargo = cargo;
            Salario = salario;
        }
    }
}
