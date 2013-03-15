using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KontoExempel
{
    public class SparKonto : Konto
    {
        private int antalUttag;

        public int GetAntalUttag()
        {
            return antalUttag;
        }

        public override bool Uttag(double belopp)
        {
            bool ut = base.Uttag(belopp);

            if (ut == true)
                antalUttag++;
            return ut;
        }
    }
}
