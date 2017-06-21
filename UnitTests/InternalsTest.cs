using System;
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

            Library.InternalClass ic = new InternalClass();
        }
        
    }
}
