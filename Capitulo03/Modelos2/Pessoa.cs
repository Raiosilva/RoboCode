using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo03.Modelos2
{
    class Pessoa
    {
        public Pessoa(string cpf, string nome)
        {
            CPF = cpf;
            Nome = nome;
        }

        public string CPF { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
    }
}
