using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KontoExempel
{
    public class Konto
    {
        // Deklaration av medlemsattribut

        private string kontoNummer;
        protected double saldo;

        #region Konstruktorer

        // Default konstruktor
        public Konto():this("Kontonummer saknas", 100)
        {
            Console.WriteLine("\nDefaultkonsturktor använd");
        }

        public Konto(string knr):this(knr, 100)
        {
            Console.WriteLine("\nKonstruktor som tar emot endast kontonummer använd");
        }

        public Konto(string knr, double belopp)
        {
            kontoNummer = knr;
            saldo = belopp;
            Console.WriteLine("\nKonstruktor som tar både belopp och kontonummer Använd");
        }

        #endregion

        public override string ToString()
        {
            string s = "\nKontonummer: " + kontoNummer + "\nSaldo: " + saldo;
            return s;
        }

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

        public double SaldoBesked()
        {
            return saldo; //Skicka tillbaka en kopia av innehållet i saldo.
        }

        public void SetKontoNummer(string knr)
        {
            kontoNummer = knr;
        }

        public string GetKontoNummer()
        {
            return kontoNummer;
        }
    }
}
