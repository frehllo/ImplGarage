using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiGarage
{
    public class Garage
    {
        public string Località { get; private set; }
        public List<Livello> Livelli { get; private set; }

        public Garage(string l)
        {
            Località = l;
        }

        public bool Parcheggiata(Auto auto)
        {
            bool parcheggiata = false;
            foreach (Livello l in Livelli)
            {
                if (l.Parcheggi.Contains(auto.Parcheggio))
                {
                    parcheggiata = true;
                }
            }
            return parcheggiata;
        }

        public Biglietto Parcheggia(Auto auto)
        {
            //trovare dati da passare
            auto.Parcheggio = new Parcheggio();
            auto.Biglietto = new Biglietto(DateTime.Now, auto, auto.Parcheggio);
            return auto.Biglietto;
        }
    }
}
