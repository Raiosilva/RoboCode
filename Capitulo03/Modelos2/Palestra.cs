using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo03.Modelos2
{
    class Palestra
    {
        public string Titulo {get; set;}
        public string Local { get; set; }
        public DateTime DataHora { get; set; }
        public Executivo Palestrante { get; set; }

        public Palestra(string titulo, string local, DateTime datahora, Executivo palestrante)
        {
            Titulo = titulo;
            Local = local;
            DataHora = datahora;
            Palestrante = palestrante;

        }
        public string GetInfo()
        {
            return "Palestra" + Titulo + " em " + Local + " na data " + DataHora + " por " + Palestrante.Nome;
        }

    }
}
