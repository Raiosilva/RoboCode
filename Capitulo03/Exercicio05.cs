using System;
using System.Collections.Generic;
using System.Text;
using Capitulo03.Modelos;

namespace Capitulo03
{
    class Exercicio05
    {
        static void NotMain(string[] args)
        {
            Pessoa03 p = new Pessoa03();
            p.nome = "Raimundo";
            p.sobrenome = "Oliveira";
            p.salario = -1000f;
            Console.WriteLine(p.nome);
            Console.ReadKey();
        }
    }
}
