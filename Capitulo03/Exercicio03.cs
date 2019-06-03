using System;
using System.Collections.Generic;
using System.Text;
using Capitulo03.Modelos;

namespace Capitulo03
{
    class Exercicio03
    {
        static void NotMain(string[] args)
        {
            Pessoa01 p = new Pessoa01();
            // p = null; 
            Console.WriteLine(p.pais.Length);
            Console.ReadKey();
        }
    }
}
