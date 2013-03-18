using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KontoExempel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Konto mittKonto;
            //mittKonto = new Konto();
            //Console.WriteLine(mittKonto.ToString());

            //SparKonto sKonto = new SparKonto("23456", 2000);
            //Console.WriteLine(sKonto.ToString());

            //Konto konto1 = new Konto("1234-567");

            //Konto kont2 = new Konto("2345-333", 2000);

            //mittKonto.SetKontoNummer("1234-56");
            //mittKonto.Insattning(8000);
            //// double saldot = mittKonto.SaldoBesked();

            //SparKonto sKonto = new SparKonto();
            //SparKonto sKonto2 = new SparKonto("12356-456");
            //SparKonto sKonto3 = new SparKonto("1234-567", 1500);

            //sKonto.Insattning(3500);
            //sKonto.SetKontoNummer("2345-78");
            //Console.WriteLine("Du har gjort {0} uttag fr kontonr {1}", sKonto.GetAntalUttag(), sKonto.GetKontoNummer());

            //sKonto.Uttag(3000);
            //Console.WriteLine("Du har nu {0} SEK i ditt Sparkonto och har gjort {1} Uttag", sKonto.SaldoBesked(), sKonto.GetAntalUttag());
            //sKonto.Uttag(300);
            //Console.WriteLine("Du har nu {0} på ditt konto och gjort {1} antal uttag", sKonto.SaldoBesked(),
            //                  sKonto.GetAntalUttag());
            
            //Console.WriteLine();
            //Console.WriteLine("--------------- Konto: {0}--------------------------- \n", mittKonto.GetKontoNummer());
            //Console.WriteLine(mittKonto.SaldoBesked());


            //bool ut;
            //ut = mittKonto.Uttag(3000);
            //Console.WriteLine("Ditt Saldo på kontot är nu {0} SEK", mittKonto.SaldoBesked());
            //Console.WriteLine("Gick det att ta ut pengar?" + ut);
            //Console.WriteLine("Nu finns det " + mittKonto.SaldoBesked());
            //Console.WriteLine();
            

            //Konto mittKonto2;
            //mittKonto2 = new Konto();

            //mittKonto2.SetKontoNummer("23452176");
            //mittKonto2.Insattning(8000);
            //Console.WriteLine("--------------- Konto 2: {0} -------------------------- \n", mittKonto2.GetKontoNummer());
            //Console.WriteLine("Ditt Saldo på kontot är nu {0} SEK", mittKonto2.SaldoBesked());

            //bool ut2;
            //ut2 = mittKonto2.Uttag(9000);
            //Console.WriteLine("Gåre det att ta ut pengar? {0}", ut2);
            //Console.WriteLine("Ditt Saldo på kontot är nu {0} SEK", mittKonto2.SaldoBesked());

            //KreditKonto kKonto = new KreditKonto();
            //KreditKonto kKonto2 = new KreditKonto("1234-567", 10000);
            KreditKonto kKonto3 = new KreditKonto("234-678", 5300, 15000);
            Console.WriteLine(kKonto3.ToString());
     
            
            
            //kKonto.SetKredit(10000);
            //kKonto.Insattning(5000);
            //Console.WriteLine("Saldo är: " + kKonto.SaldoBesked());
            //kKonto.Uttag(12000);
            //Console.WriteLine("Uttag gjort. Saldobesked: " + kKonto.SaldoBesked());
            //Console.WriteLine("Din kredit är: " + kKonto.GetKredit());
            


            Console.ReadLine();

            #region Egna tester

            //double insattning = AddFunds();
            //mittKonto.Insattning(insattning);
            //Console.WriteLine(mittKonto.SaldoBesked());

            //Console.ReadLine();

            #endregion

        }

        #region Egna tester

        //public static double AddFunds()
        //{
        //    Console.Write("Hur mycket vill du sätta in?");
        //    double addMoney = double.Parse(Console.ReadLine());
        //    return addMoney;
        //}

        #endregion
    }
}
