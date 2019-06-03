using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo03.Modelos
{
    class Conta01
    {
        public string NomeTitular { get; set; }
        public float Saldo { get; set; }
        public Boolean Especial { get; set; }
        public float Limite { get; set; }

        const float LIMITE_PADRAO = 100;


        public Conta01(string nomeTitular)
        {
            Console.WriteLine("Primeiro Construtor");
            this.NomeTitular = nomeTitular;
            this.Especial = false;
            this.Saldo = 0;
            this.Limite = 0;
        }

        public Conta01(string nomeTitular, bool especial)
        {
            this.NomeTitular = nomeTitular;
            this.Especial = especial;
            this.Saldo = 0;
            this.Limite = especial ? LIMITE_PADRAO : 0;
        }

        public Conta01(string nomeTitular, bool especial, float limite)
        {
            if (!especial && limite > 0)
                throw new ArgumentException("Somente contas especiais podem ter limite");
            this.NomeTitular = nomeTitular;
            this.Especial = especial;
            this.Saldo = 0;
            this.Limite = especial ? limite :0;
        }
    }
}
