using System;
using System.Collections.Generic;
using System.Text;
using Capitulo03.Modelos;

namespace Capitulo03
{
    class Exercicio17
    {
        static void NotMain(string[] args)
        {
            var q = new Quadrado(5);
            Console.WriteLine(q.CalculaArea());
            Console.ReadKey();
        }
    }
}
