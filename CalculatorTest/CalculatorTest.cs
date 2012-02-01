using Calculator;
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestDivideMethod()
        {
            //arranges the method
            var calc = new Calc();

            //shows the action
            var result = calc.Div(9, 3);

            //asserts whether the correct answer is the result
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestSubtractMethod()
        { 
            //arranges the method
            var calc = new Calc();

            //shows the action
            var result = calc.Sub(20, 5);

            //assert
            Assert.AreEqual(15, result);
        }
        
        [TestMethod]
        public void TestAdditionMethod()
        {
            //arranges the method
            var calc = new Calc();
                
            //shows the action
            var result = calc.Add(2, 4);
                
            //Assert
            Assert.AreEqual(6, result);
        }
            
        [TestMethod]
        public void TestMultiplymethod()
        {
            //arranges the method
            var calc = new Calc();
                
            //shows the action
            var result = calc.Mul(2, 4);
                
            //Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestEmptyString()
        {
            //test logic here
            Assert.Inconclusive();
        }
    }
}
