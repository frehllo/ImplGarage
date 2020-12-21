using System;

namespace ClassiGarage
{
    public class Auto
    {
        public string Targa { get; private set; }
        public int Cilindrata { get; private set; }
        public Biglietto Biglietto { get; set; }
        public Parcheggio Parcheggio { get; set; }

        public Auto(string t, int c)
        {
            Targa = t;
            Cilindrata = c;
        }
    }
}
