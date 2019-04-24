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
            Pencil pencil = new Pencil();

            string write = pencil.Write("thing");

            Assert.AreEqual(write, "thing");
        }
    }
}
