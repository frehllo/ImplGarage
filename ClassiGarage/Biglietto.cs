using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiGarage
{
    public class Biglietto
    {
        public DateTime Arrivo { get; private set; }

        public Biglietto(DateTime arrivo, Auto auto, Parcheggio parcheggio)
        {
            Arrivo = arrivo;
            parcheggio.Biglietto = this;
            auto.Biglietto = this;
        }

        public double Paga()
        {
            double tempo = double.Parse((DateTime.Now - Arrivo).ToString());
            double prezzo = tempo / 60 * 1.5;
            return prezzo;
        }
    }
}
