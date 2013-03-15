using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KontoExempel
{
    class KreditKonto : Konto
    {
        private double kredit;

        public void SetKredit(double b)
        {
            kredit = b;
        }


        public double GetKredit()
        {
            return kredit;
        }

        public override bool Uttag(double belopp)
        {
            if (belopp <= kredit + saldo)
            {
                saldo -= belopp;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
