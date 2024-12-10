using System;

namespace SolveMathSecondExpression.Lib
{
    public class MathSecondExpression
    {
        public double CalculateSecondExpression(double x, double y, double a)
        {
            double res = 3 * y + (2 * 3 * a) / (10 * x - 3 * a) + x / ((3 * x + a) / (x - 2));
            res = Math.Round(res, 2);
            return res;
        }
    }
}
