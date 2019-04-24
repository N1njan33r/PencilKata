using Microsoft.VisualStudio.TestTools.UnitTesting;
using PencilKata;

namespace PencilKata_Test
{
    [TestClass]
    public class Write_Test
    {
        [TestMethod]
        public void ConstructorShouldAcceptAndReturnString()
        {
            Write write = new Write("thing");

            Assert.AreEqual(write.Written, "thing");
        }
    }
}
