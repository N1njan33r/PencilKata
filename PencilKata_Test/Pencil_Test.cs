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

            Pencil pencil = new Pencil(20, 20);
            actualText = pencil.Write("thing");

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void WriteMethodShouldAppendTextToString()
        {
            string expectedText = "Hello World";
            string actualText;

            Pencil pencil = new Pencil(20, 20);
            actualText = pencil.Write("Hello");
            actualText = pencil.Write(" World");

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void PencilObjectShouldHaveFiniteDurability()
        {
            int expectedDurability = 20;
            int actualDurability;

            Pencil pencil = new Pencil(20, 20);
            actualDurability = pencil.Durability;

            Assert.AreEqual(expectedDurability, actualDurability);
        }

        [TestMethod]
        public void PencilObjectShouldLoseDurabilityWhenWriteCalled()
        {
            int expectedDurability = 18;
            int actualDurability;

            Pencil pencil = new Pencil(20, 1);
            pencil.Write("T");
            actualDurability = pencil.Durability;

            Assert.AreEqual(expectedDurability, actualDurability);
        }

        [TestMethod]
        public void PencilObjectShouldLoseOneDurabilityWhenWriteLowerCaseChar()
        {
            int expectedDurability = 19;
            int actualDurability;

            Pencil pencil = new Pencil(20, 1);
            pencil.Write("t");
            actualDurability = pencil.Durability;

            Assert.AreEqual(expectedDurability, actualDurability);
        }

        [TestMethod]
        public void PencilObjectShouldLoseNoDurabilityWhenWriteSpace()
        {
            int expectedDurability = 20;
            int actualDurability;

            Pencil pencil = new Pencil(20, 20);
            pencil.Write(" ");
            actualDurability = pencil.Durability;

            Assert.AreEqual(expectedDurability, actualDurability);
        }

        [TestMethod]
        public void PointDurabilityFallingToZeroShouldWriteOnlySpaces()
        {
            string expectedText = "Hello Wor  ";
            string actualText;

            Pencil pencil = new Pencil(20, 10);
            pencil.Write("Hello");
            pencil.Write(" World");
            actualText = pencil.Written;

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void SharpenShouldResetDurabilityToChosenValue()
        {
            string expectedText = "Hell  Worl ";
            string actualText;

            Pencil pencil = new Pencil(20, 5);
            pencil.Write("Hello");
            pencil.Sharpen(5);
            pencil.Write(" World");
            actualText = pencil.Written;

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void SharpenShouldResetDurabilityToChosenValueIfLessThanRemaining()
        {
            string expectedText = "Hell  Wo   ";
            string actualText;

            Pencil pencil = new Pencil(8, 5);
            pencil.Write("Hello");
            pencil.Sharpen(5);
            pencil.Write(" World");
            actualText = pencil.Written;

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void EraseShouldRemoveLastOccurrenceOfString()
        {
            string inputText = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
            string expectedText = "How much wood would a woodchuck chuck if a woodchuck could       wood?";
            string actualText;

            Pencil pencil = new Pencil(20, 20, 20);
            pencil.Written = inputText;
            pencil.Erase("chuck");
            actualText = pencil.Written;

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void EraseShouldOnlyEraseCharactersUntilDurabilityIsZero()
        {
            string inputText = "Buffalo Bill";
            string expectedText = "Buffalo B   ";
            string actualText;

            Pencil pencil = new Pencil(20, 20, 3);
            pencil.Written = inputText;
            pencil.Erase("Bill");
            actualText = pencil.Written;

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void EditShouldReplaceErasedText()
        {
            string inputText = "An apple a day keeps the doctor away";
            string expectedText = "An onion a day keeps the doctor away";
            string actualText;

            Pencil pencil = new Pencil(20, 20, 20);
            pencil.Written = inputText;
            pencil.Edit("apple", "onion");
            actualText = pencil.Written;

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void EditShouldReplaceErasedTextWithSymbolIfTooLong()
        {
            string inputText = "An apple a day keeps the doctor away";
            string expectedText = "An artich@k@ay keeps the doctor away";
            string actualText;

            Pencil pencil = new Pencil(20, 20, 20);
            pencil.Written = inputText;
            pencil.Edit("apple", "artichoke");
            actualText = pencil.Written;

            Assert.AreEqual(expectedText, actualText);
        }
    }
}
