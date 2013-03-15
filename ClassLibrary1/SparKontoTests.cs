using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace KontoExempel.Tests
{
    [TestFixture]
    public class SparKontoTests
    {
        [Test]
        public void SkapaSparKonto()
        {
            var mittSparKonto = new SparKonto();
            mittSparKonto.SetKontoNummer("1234-56");
            StringAssert.Contains("1234-56", mittSparKonto.GetKontoNummer());
        }

        [Test]
        public void RaknaUppAntalUttag()
        {
            var mittSparKonto = new SparKonto();
            mittSparKonto.Insattning(3500);
            mittSparKonto.Uttag(3000);
            Assert.AreEqual(1, mittSparKonto.GetAntalUttag());
        }
    }
}
