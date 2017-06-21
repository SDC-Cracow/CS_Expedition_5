using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class InternalsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Library.PublicClass pc = new PublicClass();

            Assert.IsNotNull(pc);
        }

        /// <summary>
        /// Exercise:
        /// Try to write test for method Library.InternalClass.InternalMethod() in UnitTests project
        /// </summary>
        [TestMethod]
        public void InternalMethod()
        {
            // Arrange - create object of Library.InternalClass
            // TODO : here put your code

            // Act - invoke method and get result
            // TODO : here put your code
            bool result = false;

            // Assert - Check result
            Assert.IsTrue(result);
        }
    }
}