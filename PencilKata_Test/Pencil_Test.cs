using Microsoft.VisualStudio.TestTools.UnitTesting;
using PencilKata;

namespace PencilKata_Test
{
    [TestClass]
    public class Pencil_Test
    {
        Pencil pencil = new Pencil();

        [TestMethod]
        public void WriteMethodShouldAcceptAndReturnString()
        {
            string expectedText = "thing";

            string actualText = pencil.Write("thing");

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void WriteMethodShouldAppendTextToString()
        {
            string expectedText = "Hello World";
            string actualText;

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
    }
}
