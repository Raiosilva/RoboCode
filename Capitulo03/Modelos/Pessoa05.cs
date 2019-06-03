using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo03.Modelos
{
    enum Sexo {  Masculino, Feminino };
    class Pessoa05
    {
        private float _salario;
        private DateTime _datanascimento;


        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public string NomeCompleto
        {
            get
            {
                return this.Nome + " " + this.Sobrenome;
            }
        }
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
                Salario = value;
            }
        }
        public DateTime DataNascimento
        {
            get
            {
                return _datanascimento;
            }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentOutOfRangeException("DataNascimento");

                int anosCompletos = DateTime.Today.Year - value.Year;
                if (anosCompletos > 150)
                    throw new ArgumentOutOfRangeException("DataNascimento");

                _datanascimento = value;
            }
        }

        public int AnosCompletos
        {
            get { return DateTime.Today.Year - _datanascimento.Year;  }
        }

        public Sexo Sexo { get; set; }
        public string Cargo { get; set; }
        public string Pais { get; set; }


    }
}
