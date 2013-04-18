using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using KontoExempel;

namespace KontoExempel.Tests
{

    [TestFixture]
    class KreditKontoTests
    {
        [Test]
        public void CreateKreditKontoDefConstructor()
        {
            KreditKonto kKonto = new KreditKonto();
            StringAssert.Contains("xxx-xxx", kKonto.KontoNummer);
        }

        // Not working have a console read in the static constructor
        //[Test]
        //public void SetKreditRateWithStaticMemberField()
        //{
        //    var mittTestKKonto = new KreditKonto("123-567", 500, 15000);

        //    Assert.AreEqual(1, Konto.Count); // ??????
        //}

    }
}
