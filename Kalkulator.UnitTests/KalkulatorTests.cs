using System;
using NUnit.Framework;
using Kalkulator.Kalkulator;

namespace Kalkulator.UnitTests
{
    [TestFixture]
    public class KalkulatorTests
    {
        [Test]
        public void Dodawanie_CzyPoprawnyWynik(double liczba1, double liczba2, double poprawnyWynik)
        {
            var kalkulator = new Kalkulator.Program();
            wynikTestowanegoProgramu = Program
            Assert.That(Is.EqualTo(poprawnyWynik))
        }
    }
}
