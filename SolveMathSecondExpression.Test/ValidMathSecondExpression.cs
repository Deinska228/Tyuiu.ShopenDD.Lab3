using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SolveMathSecondExpression.Lib;

namespace SolveMathSecondExpression.Test
{
    [TestClass]
    public class ValidMathSecondExpression
    {
        [TestMethod]
        public void TestCalculateSecondExpression()
        {
            MathSecondExpression se = new MathSecondExpression();
            double a = 2;
            double x = 6;
            double y = 9;
            double wait = 28.42;
            var res = se.CalculateSecondExpression(x, y, a);
            Assert.AreEqual(wait, res);
        }

    
    }
}
