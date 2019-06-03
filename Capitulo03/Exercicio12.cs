using System;
using System.Collections.Generic;
using System.Text;
using Capitulo03.Modelos;

namespace Capitulo03
{
    class Exercicio12
    {
        static void NotMain(string[] args)
        {

            var f = new Funcionario01("Raimundo", "Oliveira", "Cientista de Dados", 18000f);
            Console.WriteLine(f.NomeCompleto + " " + f.Salario);
            Console.ReadKey();
        }
    }
}
