using System;
using System.Collections.Generic;
using System.Text;
using Capitulo03.Modelos;

namespace Capitulo03
{
    class Exercicio01
    {
        static void NotMain(string[] args)
        {
            Pessoa01 p = new Pessoa01
            {
                nome = "Raimundo",
                pais = "Brasil"
            };
            Console.WriteLine(p.nome + " " + p.pais);
            Console.ReadKey();
        }
    }
}
