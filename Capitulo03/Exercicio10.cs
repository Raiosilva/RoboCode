using System;
using System.Collections.Generic;
using System.Text;
using Capitulo03.Modelos;

namespace Capitulo03
{
    class Exercicio10
    {
        static void NotMain(string[] args)
        {

            Conta07 c = new Conta07("Raimundo", true, 2000);
            c.Deposita(5000);
            c.Deposita(5000, 3);
           
            Console.WriteLine(c.Saldo);
            Console.ReadKey();
        }
    }
}
