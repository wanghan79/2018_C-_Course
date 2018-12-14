using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weituo
{
    class MathOperations
    {
        public static double MultiplyByTwo(double value)
        {
            return value * 2;
        }
        public static double Square(double value)
        {
            return value * value;
        }
    }
    delegate double DoubleOp(double x);
    class Program
    {
        static void ProcessAndDisplayNumber(DoubleOp action, double value)
	    {
		double result = action(value);
		Console.WriteLine("Value is {0}, result of operation is {1}",
								value, result);
	    }
        static void Main(string[] args)
        {
            DoubleOp[] operations = { MathOperations.MultiplyByTwo,
						MathOperations.Square };
            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine("Using operations[{0}]:", i);
                ProcessAndDisplayNumber(operations[i], 2.0);
                ProcessAndDisplayNumber(operations[i], 7.94);
                ProcessAndDisplayNumber(operations[i], 1.414);
                Console.WriteLine();
            }
        }
    }
}
