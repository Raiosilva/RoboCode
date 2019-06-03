using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo03.Modelos
{
    // enum Sexo {  Masculino, Feminino };
    class Pessoa07
    {
        private DateTime _datanascimento;


        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        private string NomeCompleto
        {
            get
            {
                return this.Nome + " " + this.Sobrenome;
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
        public string Pais { get; set; }

        public Pessoa07(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            var str = NomeCompleto;
        }
    }
}
