using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SolveMathFirstExpression.Lib;

namespace SolveMathFirstExpression.Test
{
    [TestClass]
    public class ValidMathFirstExpression
    {
        [TestMethod]
        public void TestCalculateFirstExpression()
        {
            MathFirstExpression fe = new MathFirstExpression();
            double a = 2;
            double x = 6;
            double y = 9;
            double wait = -7.88;
            var res = fe.CalculateFirstExpression(x, y, a);
            Assert.AreEqual(wait, res);
        }

    }
}
