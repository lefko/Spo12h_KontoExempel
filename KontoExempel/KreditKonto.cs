﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KontoExempel
{
    public class KreditKonto : Konto
    {
        private double kredit;

        #region Konstruktorer

        public KreditKonto():base()
        {
            kredit = 0;
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
            string s = base.ToString() + "\nKredit: " + kredit;
            return s;
        }
    }
}
