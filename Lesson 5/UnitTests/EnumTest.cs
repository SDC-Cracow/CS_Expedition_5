using System;
using CS_Expedition_5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class EnumTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            MySampleEnum a = MySampleEnum.Value1;
            MySampleEnum b = MySampleEnum.Value5;

            switch (a)
            {
                case MySampleEnum.Value1:
                    break;

                case MySampleEnum.Value2:
                    break;

                case MySampleEnum.Value3:
                    break;

                case MySampleEnum.Value4:
                    break;

                //case MySampleEnum.Value5:
                //    break;
            }

            Assert.AreEqual(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestMethod2()
        {
            // declare empty array
            var arr = new int[] { };

            // throws IndexOutOfRangeException
            var w = arr[1];
        }

        /// <summary>
        /// Test will fail because of different kind of exception will be thrown
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(OutOfMemoryException))]
        public void TestMethod3()
        {
            // declare empty array
            var arr = new int[] { };

            // throws IndexOutOfRangeException
            var w = arr[1];
        }
    }
}