using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTestProject
{
    [TestClass]
    public class CalculatorLogicUnitTests
    {

        [TestMethod]
        public void Addition()
        {
            //arrange
            decimal n = 2;
            decimal m = 2;

            //act
            decimal result = WindowsFormsTestDemoApp.CalculatorLogic.add(n, m);
            
            //assert
            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void Multiplication()
        {
            //arrange
            decimal n = 2;
            decimal m = 2;

            //act
            decimal result = WindowsFormsTestDemoApp.CalculatorLogic.multiply(n, m);

            //assert
            Assert.AreEqual(result, 4);


            //arrange
            n = 3;
            m = 5;

            //act
            result = WindowsFormsTestDemoApp.CalculatorLogic.multiply(n, m);

            //assert
            Assert.AreEqual(result, 15);
        }
    }
}
