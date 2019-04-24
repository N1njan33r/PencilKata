using Microsoft.VisualStudio.TestTools.UnitTesting;
using PencilKata;

namespace PencilKata_Test
{
    [TestClass]
    public class Pencil_Test
    {
        [TestMethod]
        public void WriteMethodShouldAcceptAndReturnString()
        {
            string expectedText = "thing";
            string actualText;

            Pencil pencil = new Pencil();
            actualText = pencil.Write("thing");

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void WriteMethodShouldAppendTextToString()
        {
            string expectedText = "Hello World";
            string actualText;

            Pencil pencil = new Pencil();
            actualText = pencil.Write("Hello");
            actualText = pencil.Write("World");

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void PencilObjectShouldHaveFiniteDurability()
        {
            int expectedDurability = 20;
            int actualDurability;

            Pencil pencil = new Pencil(20);
            actualDurability = pencil.Durability;

            Assert.AreEqual(expectedDurability, actualDurability);
        }

        [TestMethod]
        public void PencilObjectShouldLoseDurabilityWhenWriteCalled()
        {
            int expectedDurability = 18;
            int actualDurability;

            Pencil pencil = new Pencil(20);
            pencil.Write("T");
            actualDurability = pencil.Durability;

            Assert.AreEqual(expectedDurability, actualDurability);
        }

        [TestMethod]
        public void PencilObjectShouldLoseOneDurabilityWhenWriteLowerCaseChar()
        {
            int expectedDurability = 19;
            int actualDurability;

            Pencil pencil = new Pencil(20);
            pencil.Write("t");
            actualDurability = pencil.Durability;

            Assert.AreEqual(expectedDurability, actualDurability);
        }
    }
}
