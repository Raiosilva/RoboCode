using System;
using System.Collections.Generic;

namespace Capitulo04
{
    class Exercicio01
    {
        static void NotMain(string[] args)
        {
            var listaPaises = new List<string>();

            listaPaises.Add("Brasil");
            listaPaises.Add("Argentina");
            listaPaises.Add("Colômbia");
            listaPaises.Add("Itália");

            foreach(var nome in listaPaises)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("Total de elementos: " + listaPaises.Count);
        }
    }
}
