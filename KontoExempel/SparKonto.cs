﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KontoExempel
{
    public class SparKonto : Konto
    {
        private int antalUttag;

        #region Konstruktorer
        
        public SparKonto():base()
        {
            antalUttag = 0;
            Console.WriteLine("Sparkonotots def konstruktor använd");
        }
        
        public SparKonto(string knr):base(knr)
        {
            antalUttag = 0;
            Console.WriteLine("Sparkonotots konstruktor som tar bara kontonummer använd");
        }

        public SparKonto(string knr, double b) : base(knr, b)
        {
            antalUttag = 0;
            Console.WriteLine("Sparkonotots konstruktor som tar både kontonummer och belopp använd");
        }

        #endregion

        public override string ToString()
        {
            string s = base.ToString() + "\nAntal gjorda uttag: " + antalUttag;
            return s;
        }

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
