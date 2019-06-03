using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo03.Modelos
{
    class Quadrado : FiguraGeometrica
    {
        public int L { get; set;  }
        public Quadrado(int 1)
        {
            L = 1;
        }

        public override float CalculaArea()
        {
            return L * L;
        }
    }
}
