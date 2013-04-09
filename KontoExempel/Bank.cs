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
<<<<<<< HEAD
            Console.WriteLine("\n\nVaälj\n1. Lägg till konto\n3. Skriv ut\n4.Avsluta");
=======
            Console.WriteLine("\n\nVaälj\n1. Lägg till konto\n3. Skrivut\n4.Avsluta");
>>>>>>> feaa45238962ecf02c9a0182d2697a2e1d4bf092

            choise = int.Parse(Console.ReadLine());
        }

        #endregion
    }
}
