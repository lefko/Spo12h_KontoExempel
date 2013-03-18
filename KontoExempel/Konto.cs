using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KontoExempel
{
    public class Konto
    {
        // Deklaration av medlemsattribut

        #region Fields / medlemmsattribut

        private string kontoNummer;
        protected double saldo;

        #endregion


        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public string KontoNummer
        {
            get { return kontoNummer; }
            set
            {
                if (value[3] == '-')
                    kontoNummer = value;
            }
        }



        #region Konstruktorer

        // Default konstruktor
        public Konto():this("xxx-xxx", 100)
        {
            Console.WriteLine("\nDefaultkonsturktor använd");
        }

        public Konto(string knr):this(knr, 100)
        {
            Console.WriteLine("\nKonstruktor som tar emot endast kontonummer använd");
        }

        public Konto(string knr, double belopp)
        {
            KontoNummer = knr;
            saldo = belopp;
            Console.WriteLine("\nKonstruktor som tar både belopp och kontonummer Använd");
        }

        #endregion

        #region Methods

        public virtual bool Uttag(double belopp)
        {
            if (belopp <= saldo)
            {
                saldo -= belopp;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Insattning(double belopp)
        {
            saldo += belopp;
        }

        public override string ToString()
        {
            string s = "\nKontonummer: " + kontoNummer + "\nSaldo: " + saldo;
            return s;
        }

        #endregion

    }
}
