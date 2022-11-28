using System;

namespace Bank
{
    public class Konto
    {
        private int guthaben;

        public int Guthaben
        {
            get
            {
                return guthaben;
            }
        }

        public Konto(int guthaben)
        {
            this.guthaben = guthaben;
        }

        public void Einzahlen(int betrag)
        {
            if(betrag > 0)
            {
                guthaben += betrag;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Keine Negativen Beträge");
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
                throw new ArgumentOutOfRangeException("Guthaben nicht ausreichend");
            }
        }
    }
}
