using System;
using System.Collections.Generic;
using Capitulo04.Modelo;

namespace Capitulo04
{
    class Exercicio07
    {
        static void Main(string[] args)
        {

            var pessoas = new List<Pessoa>
            {
                new Aluno { Nome = "João", Curso = "Ciência da Computação"},
                new Funcionario { Nome = "Márcia", Salario = 15000f },
                new Aluno { Nome = "José", Curso = "Estatistica"},
                new Funcionario { Nome = "Marcos", Salario = 8000f}
            };

            foreach (var pessoa in pessoas)
            {
                if (pessoa is Aluno)
                {
                    var aluno = pessoa as Aluno;

                    Console.WriteLine("Aluno " + aluno.Nome + " é do curso de " + aluno.Curso);
                }
                if (pessoa.GetType() == typeof(Funcionario))
                {
                    var funcionario = pessoa as Funcionario;
                    Console.WriteLine("Funcionario " + funcionario.Nome + " possui salário " + funcionario.Salario);
                }
            }
        }
    }
}
