using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KontoExempel
{
    public class KreditKonto : Konto
    {
        private static double kreditRate;
        private double kredit;

        #region Konstruktorer

        public KreditKonto()
            : base()
        {
            Kredit = 0;
            Console.WriteLine("KreditKonto def konstruktor använd");
        }

        static KreditKonto()
        {
            Console.Write("Ange kredit räntan: ");
            KreditRate = double.Parse(Console.ReadLine());
        }

        public KreditKonto(string knr, double kred)
            : base(knr)
        {
            Kredit = kred;
            Console.WriteLine("KreditKonto konstruktor som tar kontonummer använd");
        }

        public KreditKonto(string knr, double belopp, double kred)
            : base(knr, belopp)
        {
            Kredit = kred;
            Console.WriteLine("Kreditkonto konstruktor som tar kontonummer och saldo använd");
        }

        #endregion

        #region Properties

        public double Kredit
        {
            get { return kredit; }
            set
            {
                if (value >= 0)
                    kredit = value;
            }
        }

        public static double KreditRate
        {
            get { return kreditRate; }
            set
            {
                if (value >= 0)
                    kreditRate = value;
            }
        }
        #endregion

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

        public double TillgangligtBelopp()
        {
            return kredit + saldo;
        }

        public override string ToString()
        {
            string s = base.ToString() + "\nKredit: " + kredit + "\nKredit ränta: " + KreditRate;
            return s;
        }
    }
}
