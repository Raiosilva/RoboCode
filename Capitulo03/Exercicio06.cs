using System;
using System.Collections.Generic;
using System.Text;
using Capitulo03.Modelos;

namespace Capitulo03
{
    class Exercicio06
    {
        static void NotMain(string[] args)
        {
            var p = new Pessoa04();
            p.Nome = "Raimundo";
            p.Sobrenome = "Oliveira";
            Console.WriteLine(p.NomeCompleto);

            p.Salario = -1000f;
            Console.WriteLine(p.Salario);
            Console.ReadKey();
        }
    }
}
