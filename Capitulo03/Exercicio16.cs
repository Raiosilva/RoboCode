using System;
using System.Collections.Generic;
using System.Text;
using Capitulo03.Modelos;

namespace Capitulo03
{
    class Exercicio16
    {
        static void nOTMain(string[] args)
        {
            var f = new Funcionario03("João", "Silva", "Cientista de Dados", 18000f);
            Console.WriteLine(f.GetTotalPagar());

            var v = new Vendedor("Roberto", "Silva", 5000f);
            Console.WriteLine(v.GetTotalPagar());
            Console.ReadKey();
        }
    }
}
