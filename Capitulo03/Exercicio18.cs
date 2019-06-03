using System;
using System.Collections.Generic;
using System.Text;
using Capitulo03.Modelos;
using Capitulo03.Modelos2;

namespace Capitulo03
{
    class Exercicio18
    {
        static void Main(string[] args)
        {
            var tiago = new Executivo("111.111.111-11", "Tiago", 2000f, 15);
            var palestraCienciaDados = new Palestra("Ciência de Dados no Brasil", "São Paulo", new DateTime(), tiago);

            Console.WriteLine(palestraCienciaDados.GetInfo());
            Console.ReadKey();
        }
    }
}
