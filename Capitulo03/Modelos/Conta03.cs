using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo03.Modelos
{
    class Conta03
    {
        public string NomeTitular { get; set; }
        public float Saldo { get; set; }
        public Boolean Especial { get; }
        public float Limite { get; set; }

        const float LIMITE_PADRAO = 1000;


        public Conta03(string nomeTitular)
        {
            Console.WriteLine("Primeiro Construtor");
            this.NomeTitular = nomeTitular;
            this.Especial = false;
            this.Saldo = 0;
            this.Limite = 0;
        }

        public Conta03(string nomeTitular, bool especial) : this(nomeTitular)
        {
            Console.WriteLine("Primeiro Construtor");
            this.Especial = especial;
            this.Limite = especial ? LIMITE_PADRAO : 0;
        }

        public Conta03(string nomeTitular, bool especial, float limite) : this(nomeTitular, especial)
        {
            Console.WriteLine("Primeiro Construtor");

            if (!especial && limite > 0)
                throw new ArgumentException("Somente contas especiais podem ter limite");
            
            this.Limite = especial ? limite : 0;
        }
    }
}
