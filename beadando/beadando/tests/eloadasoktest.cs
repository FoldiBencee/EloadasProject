using System;
using NUnit.Framework;
namespace beadando.tests
{
    [TestFixture]
    public class eloadasoktest
    {
        Eloadas e;
        [SetUp]
        public void SetUp()
        {
        e = new Eloadas(55, 55);
        }

        [TestCase]
        public void MindLefoglal()
        {
            for (int i = 0; i < 55 * 55; i++)
            {
                e.Lefoglal();

            }
            Assert.AreEqual(true, e.teli());
        }

        [TestCase]
        public void Foglalas()
        {
            e.Lefoglal();
            Assert.AreEqual(10, e.SzabadHelyek());

        }



        [TestCase]
        public void FoglaltHely()
        {
            e.Lefoglal();
            Assert.AreEqual(false, e.Foglalt(22, 33));
        }



        [TestCase]
        public void Foglalaska()
        {
            Assert.IsTrue(e.Lefoglal());
        }

        [TestCase]
        public void tobbetnefoglalhasson()
        {
            Assert.Throws<ArgumentException>(() =>
            {


                e.Foglalt(9, 66);
            });
        }

        [TestCase]


       public void Negativletrehozas()
        {
            var rep = new Eloadas(-44, -55);

        }


    }
}
