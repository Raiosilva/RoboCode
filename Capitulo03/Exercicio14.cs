using System;
using System.Collections.Generic;
using System.Text;
using Capitulo03.Modelos;

namespace Capitulo03
{
    class Exercicio14
    {
        static void NotMain(string[] args)
        { 
            var p = new Pessoa08("João", "Silva");
            var p2 = new Pessoa08("Raimundo", "Oliveira");
            var p3 = new Pessoa08("Raimundo", "Oliveira");
            Console.WriteLine("Total de objetos criados: " + Pessoa08.GetQuantidade());
            Console.ReadKey();
        }
    }
}
