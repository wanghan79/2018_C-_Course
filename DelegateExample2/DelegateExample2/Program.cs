using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample2
{


    class A
    {
        public static double Mul_Two(double value)
        {
            return value * 2;
        }
        public static double Square(double value)
        {
            return value * value;
        }
    }
    public delegate double Func(double value);
    class Program
    {
      
      
        static void Main(string[] args)
        {
            A a = new A();
            Func d1 = new Func(A.Mul_Two);
            Func d2 = new Func(A.Square);
            string input = Console.ReadLine();
            double input_c = Convert.ToDouble(input);
            while (input_c != 0)
            {
                double ans1 = d1(input_c);
                Console.WriteLine("answer:{0}", ans1);
                double ans2 = d2(input_c);
                Console.WriteLine("answer:{0}", ans2);
                input = Console.ReadLine();
                input_c = Convert.ToDouble(input);
            }
            
            Console.ReadLine();
        }
    }
}
