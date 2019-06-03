using Capitulo03.Modelos.Exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo03.Modelos
{
    class Conta07
    {
        private float _saldo;
        public string NomeTitular { get; set; }
        public float Saldo
        {
            get { return _saldo; }
        }
        public Boolean Especial { get; }
        public float Limite { get; set; }

        const float LIMITE_PADRAO = 1000;


        public Conta07(string nomeTitular)
        {
            Console.WriteLine("Primeiro Construtor");
            this.NomeTitular = nomeTitular;
            this.Especial = false;
            this._saldo = 0;
            this.Limite = 0;
        }

        public Conta07(string nomeTitular, bool especial) : this(nomeTitular)
        {
            Console.WriteLine("Primeiro Construtor");
            this.Especial = especial;
            this.Limite = especial ? LIMITE_PADRAO : 0;
        }

        public Conta07(string nomeTitular, bool especial, float limite) : this(nomeTitular, especial)
        {
            Console.WriteLine("Primeiro Construtor");

            if (!especial && limite > 0)
                throw new ArgumentException("Somente contas especiais podem ter limite");
            
            this.Limite = especial ? limite : 0;
        }

        public void Deposita(float valor)
        {
            if (valor <= 0)
                throw new ArgumentOutOfRangeException("valor");
            this._saldo += valor;
        }
       
        public void Deposita(float valor, int emQuantosDias)
        {
            if (emQuantosDias == 0)
                Deposita(valor);
            else
            {
                Console.WriteLine("Agendamento de " + valor + " para " + emQuantosDias + " dias ");
            }
        }

        public void Saca(float valor)
        {
            if (valor <= 0)
                throw new ArgumentOutOfRangeException("valor");
            if (valor > (_saldo + Limite))
                throw new SaldoInsuficienteException();
            this._saldo -= valor;
        }

       
    }
}
