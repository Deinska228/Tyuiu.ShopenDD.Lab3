using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SolveTabMathFunction.Lib;

namespace SolveTabMathFuction.Test
{
    [TestClass]
    public class ValidTabMathFunction
    {
        [TestMethod]
        public void TestCalculateTabMathFuction()
        {
            TabMathFunction tmf = new TabMathFunction();
            
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;
            double[] valueWaitArray = new double[len];

            valueWaitArray[0] = 25.86;
            valueWaitArray[1] = 16.79;
            valueWaitArray[2] = 9.66;
            valueWaitArray[3] = 4.44;
            valueWaitArray[4] = 1.38;
            valueWaitArray[5] = 0;
            valueWaitArray[6] = 1.38;
            valueWaitArray[7] = 4.44;
            valueWaitArray[8] = 9.66;
            valueWaitArray[9] = 16.79;
            valueWaitArray[10] = 25.86;


            double[] res = new double[len];
            res = tmf.CalculateTabMathFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
