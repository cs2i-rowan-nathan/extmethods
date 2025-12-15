using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dummy.Extensions;

namespace TestProject1
{
    [TestClass]
    public class IntExtensionsTests
    {
        [TestMethod]
        public void NotEven_ReturnsFalse_ForEvenNumber()
        {
            int number = 4;

            bool result = number.NotEven();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NotEven_ReturnsTrue_ForOddNumber()
        {
            int number = 5;

            bool result = number.NotEven();

            Assert.IsTrue(result);
        }
    }
}

