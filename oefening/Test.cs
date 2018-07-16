using NUnit.Framework;
using NUnitLite;

namespace Tests
{
    [TestFixture]
    public class TestClass
    {
        // Array voor functieargument
        int[] a = new int[] { -2, 11, -4, 11, -3, 15, -2, 7, 24, 8 };

        // deze functie is nodig om de testen achteraf via de webinterface uit te voeren
        public static int Run(string resultPath)
        {
            string[] args = { "--work=" + resultPath };
            return new AutoRun().Execute(args);
        }

        [Test]
        public void TestBerekenSom()
        {
            Assert.That(First.Program.BerekenSom(a), Is.EqualTo(65));
        }
        [Test]
        public void TestBerekenGem()
        {
            Assert.That(First.Program.BerekenGem(a), Is.EqualTo(6.5));
        }

        [Test]
        public void TestZoekGetal1()
        {
            Assert.That(First.Program.ZoekGetal1(a, 7), Is.EqualTo(true));
            Assert.That(First.Program.ZoekGetal1(a, 77), Is.EqualTo(false));
        }

        [Test]
        public void TestZoekGetal2()
        {
            Assert.That(First.Program.ZoekGetal2(a, 11), Is.EqualTo(2));
            Assert.That(First.Program.ZoekGetal2(a, 100), Is.EqualTo(0));
        }

        [Test]
        public void TestZoekGrootste()
        {
            Assert.That(First.Program.ZoekGrootste(a), Is.EqualTo(24));
        }

        [Test]
        public void TestTelNegPos()
        {
            Assert.That(First.Program.TelNegPos(a), Is.EqualTo("Neg: 4 Pos: 6"));
        }

    }
}
