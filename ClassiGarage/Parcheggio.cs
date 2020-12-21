using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiGarage
{
    public class Parcheggio
    {
        public int Numero { get; private set; }
        public char Lettera { get; private set; }
        public Auto Auto { get; set; }
        public Biglietto Biglietto { get; set; }

        public Parcheggio(int numero, char lettera, Livello livello)
        {
            Numero = numero;
            Lettera = lettera;
            livello.Parcheggi.Add(this);
        }
    }
}
