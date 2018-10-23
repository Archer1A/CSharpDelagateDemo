﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateDemo
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            //委托静态方法，也可以委托实例方法
            MathsOp operations = new MathsOp(MathOperations.MultipBy2);
            operations += new MathsOp(MathOperations.Squre);
            double x = 1.23;
            operations(x);
            operations -= new MathsOp(MathOperations.MultipBy2);
            operations(x);
            //double result = operations(x);
            //Console.WriteLine("{0} multply by 2 is {1}", x, result);
            Console.Read();
        }
    }
}
