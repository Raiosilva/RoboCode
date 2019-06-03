using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo03.Modelos
{
    class Conta
    {
        public string NomeTitular { get; set; }
        public float Saldo { get; set; }

        public Conta(string nomeTitular)
        {
            this.NomeTitular = nomeTitular;
        }
    }
}
