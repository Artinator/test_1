using System;
using HelperTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _HelperToolsTests
{
    [TestClass]
    public class MathHelperTests
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            Assert.IsTrue(MathHelper.Add(3, 4) == 7);
        }
    }
}
