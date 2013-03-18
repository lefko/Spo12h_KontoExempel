using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KontoExempel
{
    class KreditKonto : Konto
    {
        private double kredit;

        public KreditKonto():base()
        {
            Console.WriteLine("KreditKonto def konstruktor använd");
        }

        public KreditKonto(string knr, double kred):base(knr)
        {
            kredit = kred;
            Console.WriteLine("KreditKonto konstruktor som tar kontonummer använd");
        }

        public KreditKonto(string knr, double belopp, double kred):base(knr, belopp)
        {
            kredit = kred;
            Console.WriteLine("Kreditkonto konstruktor som tar kontonummer och saldo använd");
        }

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
