using System;
using System.Collections.Generic;
using System.Text;
using Capitulo03.Modelos;

namespace Capitulo03
{
    class Exercicio08
    {
        static void NotMain(string[] args)
        {

            Conta c = new Conta("Raimundo");
            c.Saldo = 1000000;
           
            Console.WriteLine(c.NomeTitular + " " + c.Saldo);
            Console.ReadKey();
        }
    }
}
