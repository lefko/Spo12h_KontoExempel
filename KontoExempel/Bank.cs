using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KontoExempel
{
    class Bank
    {
        #region Fields
        
        private Konto[] konton;
        
        #endregion

        #region Constructors

        public Bank()
        {
            konton = new Konto[10];
        }

        #endregion

        #region Methods

        public void AddKonto()
        {
            string knr;
            double saldo;
            //Leta upp första lediga plats
            int i = Array.IndexOf(konton, null);
            //Lägg till om det finns plats
            if (i != -1)
            {
                Console.Write("Kontonummer: ");
                knr = Console.ReadLine();
                Console.Write("Saldo: ");
                saldo = double.Parse(Console.ReadLine());
                konton[i] = new Konto(knr, saldo);
            }
        }

        public void Print()
        {
            Console.WriteLine("Banken har {0} konton.\n", Konto.Count);
            foreach (Konto k in konton)
            {
                if (k != null)
                    Console.WriteLine(k.ToString());
            }
        }

        #endregion
    }
}
