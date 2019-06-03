using System;
using System.Collections.Generic;
using System.Text;
using Capitulo03.Modelos;

namespace Capitulo03
{
    class Exercicio02
    {
        static void NotMain(string[] args)
        {
            Pessoa01 p = new Pessoa01();
            p.nome = "Raimundo";
            p.pais = "Brasil";

            Pessoa01 p2 = p;
            p2.nome = "Raimundo";

            Console.WriteLine(p.nome);
            Console.ReadKey();
        }
    }
}
