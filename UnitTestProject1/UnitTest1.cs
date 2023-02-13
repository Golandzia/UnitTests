using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class CoreTests
    {
        Core core = new Core();
        [TestMethod()]
        public void ExistTest_False()
        {


            //Allert
            double a = 1;
            double b = 2;
            double c = 3;

            bool expected = false;
            //Act
            var result = core.TestOfTriangle(a, b, c);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ExistTest_True()
        {


            //Allert
            double a = 3;
            double b = 4;
            double c = 5;

            bool expected = true;
            //Act
            var result = core.TestOfTriangle(a, b, c);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
