using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Example
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
    public delegate double Fun(double value); //声明委托；
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Fun d1 = new Fun(A.Mul_Two);      //调用这个委托
            Fun d2 = new Fun(A.Square);
            string input = Console.ReadLine();
            double input_c = Convert.ToDouble(input);
            while (input != null)
            {
                double ans1 = d1(input_c);
                Console.WriteLine("answer1 = : {0}", ans1);
                double ans2 = d2(input_c);
                Console.WriteLine("answer2 = : {0}", ans2);
                input = Console.ReadLine();
                input_c = Convert.ToDouble(input);
            }
            Console.ReadLine();
        }
    }
}
/*
 委托相当于是可以储存一类函数的
     
     
     
     
     */