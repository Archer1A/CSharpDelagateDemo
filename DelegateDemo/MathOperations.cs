using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateDemo
{
    delegate void MathsOp(double x);
    // delegate double MathsOp(double x);
    class MathOperations
    {
        public static void MultipBy2(double value)
        {
            double result = value * 2;
            Console.WriteLine("Multiplying by 2: {0} gives {1}", value, result);
           // return 

        }
        public static void Squre(double value)
        {
            double result = value * value;
            Console.WriteLine("Squaring: {0} gives {1}", value, result);
        }
     
    }
}
