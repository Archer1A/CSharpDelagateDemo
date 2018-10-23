using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateDemo
{
    delegate double MathsOp(double x);
    class MathOperations
    {
        public static double MultipBy2(double value)
        {
            return value * 2;

        }
    }
}
