using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo03.Modelos
{
    class Pessoa04
    {
        private float _salario;
               
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
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public string Cargo { get; set; }
        public string Pais { get; set; }


    }
}
