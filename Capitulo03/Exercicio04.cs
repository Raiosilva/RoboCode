using System;
using System.Collections.Generic;
using System.Text;
using Capitulo03.Modelos;

namespace Capitulo03
{
    class Exercicio04
    {
        static void NotMain(string[] args)
        {
            Pessoa02 p = new Pessoa02();
            p.SetNome("Raimundo");
            p.SetSobrenome("Oliveira");
            Console.WriteLine(p.GetNomeCompleto());
            Console.ReadKey();
        }
    }
}
