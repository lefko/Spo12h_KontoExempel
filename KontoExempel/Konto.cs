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

        // Konstruktorer

        // Default konstruktor
        public Konto()
        {
            saldo = 100;
            kontoNummer = "Kontonummer saknas";
        }

        public Konto(string knr)
        {
            saldo = 100;
            kontoNummer = knr;
        }

        public Konto(string knr, double belopp)
        {
            kontoNummer = knr;
            saldo = belopp;
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
