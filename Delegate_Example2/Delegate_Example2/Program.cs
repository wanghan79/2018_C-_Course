using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Example2
{
    public class A
    {
        public static double Mul_Three(double value)
        {
            return value * 3;
        }
        public static double Square (double value)
        {
            return value * value;
        }
    }
    public delegate double Fun(double value);

    class Program
    {
        static void Number_Show(Fun action,double value)
        {
            double result = action(value);
            Console.WriteLine("Value : {0}   Results : {1}",value , result);
        }
        static double[] num = new double[3] { 2.0, 7.94, 1.414 };
        static void Main(string[] args)
        {
            Fun[] operations = { A.Mul_Three, A.Square }; //将函数委托放置在一个委托数组中
            for (int i = 0;i < operations.Length;i++)     //从委托数组中调用
            {
                Console.WriteLine("Using operations[{0}]", i);
                for (int j = 0;j < 3;j++)
                {
                    Number_Show(operations[i], num[j]);
                }
            }
            Console.ReadLine();
        }
    }
}
