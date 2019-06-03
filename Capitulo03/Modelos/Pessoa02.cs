using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo03.Modelos
{
    class Pessoa02
    {
        private string nome;
        private string sobrenome;
        private float salario;
        public int idade;
        public string sexo;
        public string cargo;
        public string pais;

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetSobrenome()
        {
            return sobrenome;
        }

        public void SetSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        public string GetNomeCompleto()
        {
            return nome + " " + sobrenome;
        }

        public float GetSalario()
        {
            return salario;
        }

        public void SetSalario(float salario)
        {
            if (salario < 0)
                throw new ArgumentOutOfRangeException("salario");
            this.salario = salario;
        }
    }
}
