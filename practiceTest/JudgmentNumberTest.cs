using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using practice.program;

namespace practiceTest
{
    [TestClass]
    public class JudgmentNumberTest
    {
        JudgmentNumber target = new JudgmentNumber();

        [TestMethod]
        public void ChangeNumber()
        {
            Assert.AreEqual(2, target.ChangeNumber(3));
            Assert.AreEqual(1, target.ChangeNumber(1));
            Assert.AreEqual(4, target.ChangeNumber(6));
            Assert.AreEqual(5, target.ChangeNumber(25));
        }

        [TestMethod]
        public void ChangeNumber_2()
        {
            Assert.AreEqual(2, target.ChangeNumber_2(3));
            Assert.AreEqual(1, target.ChangeNumber_2(1));
            Assert.AreEqual(4, target.ChangeNumber_2(6));
            Assert.AreEqual(5, target.ChangeNumber_2(25));
        }

        [TestMethod]
        public void ChangeNumber_3()
        {
            Assert.AreEqual(2, target.ChangeNumber_3(3));
            //Assert.AreEqual(1, target.ChangeNumber_2(1));
            //Assert.AreEqual(4, target.ChangeNumber_2(6));
            //Assert.AreEqual(5, target.ChangeNumber_2(25));
        }

        [TestMethod]
        public void testPredicate()
        {
            Assert.IsTrue(target.testPredicate());
        }
    }
}
