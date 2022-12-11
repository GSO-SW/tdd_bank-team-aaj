using System;

namespace Bank
{
    public class Konto
    {
        private int guthaben;
        private int kontoNr;
        static int anzahlKonten = 0;

        public Konto(int guthaben)
        {
            if(guthaben >= 0)
            {
                this.guthaben = guthaben;
                this.kontoNr = anzahlKonten + 1;
                anzahlKonten++;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Guthaben ist mit negativem Wert nicht möglich.");
            }
        }


        public int Guthaben
        {
            get
            {
                return guthaben;
            }
        }

        public int KontoNr
        {
            get { return kontoNr; }
        }

        public void Einzahlen(int betrag)
        {
            if(betrag > 0)
            {
                guthaben += betrag;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Keine Negativen Beträge.");
            }
            
        }

        public void Auszahlen(int betrag)
        {
            if (guthaben >= betrag)
            {
                guthaben -= betrag;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Guthaben ist nicht ausreichend.");
            }
        }
    }
}
