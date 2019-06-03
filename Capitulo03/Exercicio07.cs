using System;
using System.Collections.Generic;
using System.Text;
using Capitulo03.Modelos;

namespace Capitulo03
{
    class Exercicio07
    {
        static void NotMain(string[] args)
        {
            var p = new Pessoa05();
            p.Nome = "Raimundo";
            p.Sobrenome = "Oliveira";
            p.Sexo = Sexo.Masculino;
            p.DataNascimento = new DateTime(1990, 01, 17);
           
            Console.WriteLine(p.NomeCompleto + " " + p.AnosCompletos);

           
            Console.ReadKey();
        }
    }
}
