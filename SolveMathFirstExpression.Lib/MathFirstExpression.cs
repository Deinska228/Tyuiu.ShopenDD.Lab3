using System;

namespace SolveMathFirstExpression.Lib
{
    public class MathFirstExpression
    {
        public double CalculateFirstExpression(double x, double y, double a)
        {
            double res = ((a / y) / (3 * x - 2 * a)) - x + (7 * y - 3 * a) / (x - 4 * y);
            res = Math.Round(res, 2);
            return res;
        }
    }
}