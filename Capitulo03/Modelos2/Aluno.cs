using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo03.Modelos2
{
    class Aluno : Pessoa
    {
        public string Curso { get; set; }

        public Aluno(string CPF, string nome, string curso) : base(CPF, nome)
        {
            Curso = curso;
        }
    }
}
