using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace KontoExempel.Tests
{
    
    [TestFixture]
    class KreditKontoTests
    {
        [Test]
        public void CreateKreditKontoDefConstructor()
        {
            KreditKonto kKonto = new KreditKonto();
            StringAssert.Contains("Kontonummer saknas", kKonto.GetKontoNummer());
        }

    }
}
