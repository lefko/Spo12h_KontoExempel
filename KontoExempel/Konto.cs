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

        private static double rate;
        private static int count;
        private string kontoNummer;
        protected double saldo;

        #endregion

        public static int Count //Statisk Property till statisk medlemsvariabel
        {
            get { return count; }
        }

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

        static Konto()
        {
            Console.Write("Ange räntan: ");
            rate = double.Parse(Console.ReadLine());
        }

        public Konto(string knr):this(knr, 100)
        {
            Console.WriteLine("\nKonstruktor som tar emot endast kontonummer använd");
        }

        public Konto(string knr, double belopp)
        {
            count++;
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
            string s = "\nKontonummer: " + kontoNummer + "\nSaldo: " + saldo + "\nInlåningsränta: " + rate;
            return s;
        }

        #endregion

    }
}
