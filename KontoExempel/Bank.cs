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

        public void AddKreditKonto()
        {
            string knr;
            double saldo;
            double kredit;

            // Leta upp första lediga plats
            int i = Array.IndexOf(konton, null);
            //Lägg till om det finns plats
            if (i != -1)
            {
                Console.Write("Kontonummer: ");
                knr = Console.ReadLine();
                Console.Write("Saldo: ");
                saldo = double.Parse(Console.ReadLine());
                Console.Write("Kredit: ");
                kredit = double.Parse(Console.ReadLine());
                konton[i] = new KreditKonto(knr, saldo, kredit);
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

        public void Start()
        {
            bool cont = true;
            int choise;

            while (cont) //samma som att skriva: cont == true
            {
                Menu(out choise);
                switch (choise)
                {
                    case 1:
                        AddKonto();
                        break;
                    case 2:
                        AddKreditKonto();
                        break;
                    case 3:
                        Print();
                        break;
                    case 4: 
                        cont = false;
                        break;
                    default:
                        Console.WriteLine("Felval !!");
                        break;
                }
            }
        }

        public void Menu(out int choise)
        {

            Console.WriteLine("\n\nVaälj\n1. Lägg till konto\n2. Lägg till Kredit Konto\n3. Skrivut\n4.Avsluta");

            choise = int.Parse(Console.ReadLine());
        }

        #endregion
    }
}
