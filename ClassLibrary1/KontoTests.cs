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
            StringAssert.Contains("xxx-xxx", mittTestKonto.KontoNummer);
        }

        [Test]
        public void CreateAccountWhithAccountNr()
        {
            var mittTestKonto = new Konto("123-567");
            StringAssert.Contains("123-567", mittTestKonto.KontoNummer);
        }

        [Test]
        public void CreateAccountWhithAccountNrAndAddFunds()
        {
            var mittTestKonto = new Konto("123-567", 500);
            StringAssert.Contains("123-567", mittTestKonto.KontoNummer);
            Assert.AreEqual(500, mittTestKonto.Saldo);
        }

        [Test]
        public void AddCountByOneWhenCreatingAccount()
        {
            var mittTestKonto = new Konto("123-567", 500);
            Assert.AreEqual(1, Konto.Count); // ??????
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
