using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace KontoExempel.Tests
{
    [TestFixture]
    public class KontoTests
    {
        //[Test]
        //public void AFirstTest()
        //{
        //    Assert.IsTrue(true, "true is true!");
        //}

        [Test]
        public void CreateAccountWhithoutAccountNr()
        {
            var mittTestKonto = new Konto();
            StringAssert.Contains("Kontonummer saknas", mittTestKonto.GetKontoNummer());
        }

        [Test]
        public void CreateAccountWhithAccountNr()
        {
            var mittTestKonto = new Konto("1234-567");
            StringAssert.Contains("1234-567", mittTestKonto.GetKontoNummer());
        }

        [Test]
        public void CreateAccountWhithAccountNrAndAddFunds()
        {
            var mittTestKonto = new Konto("1234-567", 500);
            StringAssert.Contains("1234-567", mittTestKonto.GetKontoNummer());
            Assert.AreEqual(500, mittTestKonto.SaldoBesked());
        }

        [Test]
        public void WithdrawFundsOk()
        {
            var mittKonto = new Konto();
            mittKonto.Insattning(3000);
            bool uttag = mittKonto.Uttag(2000);
            Assert.IsTrue(uttag);
        }

        [Test]
        public void WithdrawFundsDeny() 
        {
            var mittTestKonto = new Konto();
            mittTestKonto.Insattning(3000);
            bool uttag = mittTestKonto.Uttag(4000);
            Assert.False(uttag);
        }

    }
}
