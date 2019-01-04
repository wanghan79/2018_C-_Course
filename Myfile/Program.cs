using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfile
{
    class MathOperations
    {
        public static double MultiplyByTwo(double value)
        {
            return 2 * value;
        }
        public static double Square(double value)
        {
            return value * value;
        }
    }
    delegate double DoubleOp(double x);
    class Progarm
    {
        static void ProcessAndDisplayNumber(DoubleOp action, double value)
        {
            double result = action(value);
            Console.WriteLine("Value is {0} , result of operation is {1}", value, result);
        }
        static void Main()
        {
            DoubleOp[] operations = {MathOperations.MultiplyByTwo, MathOperations.Square}; 
            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine("Using operations[{0}]:", i);
                ProcessAndDisplayNumber(operations[i], 2.0);
                ProcessAndDisplayNumber(operations[i], 7.94);
                ProcessAndDisplayNumber(operations[i], 1.414);
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
