using System;
using Calculator;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    /// <summary>
    /// Summary description for calctest
    /// </summary>
    [TestClass]
    public class calcTest
    {
            [TestMethod]
            public void Testadditionmethod()
            {
                //arrange
                var calc = new Calc();
                var result = calc.Add(2, 4);
                //Assert
                Assert.AreEqual(6, result);
            }
            [TestMethod]
            public void Testmultipilicationmethod()
            {
                //arrange
                var calc = new Calc();
                var result = calc.Mul(2, 4);
                //Assert
                Assert.AreEqual(8, result);
            }

        }

    }
    

       
       