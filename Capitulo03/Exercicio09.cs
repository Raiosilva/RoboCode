using System;
using System.Collections.Generic;
using System.Text;
using Capitulo03.Modelos;

namespace Capitulo03
{
    class Exercicio09
    {
        static void NotMain(string[] args)
        {

            Conta03 c = new Conta03("Raimundo", true, 2000);
            c.Saldo = 1000000;
           
            Console.WriteLine(c.Limite);
            Console.ReadKey();
        }
    }
}
