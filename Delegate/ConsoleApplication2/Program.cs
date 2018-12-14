using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void GreetDelegate(string name);
    class Program
    {
        private static void EnglishGreeting(string name)
        {
            Console.WriteLine("Morning," + name);
        }
        private static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好，" + name);
        }
        private static void GreetPeople(string name,GreetDelegate MakeGreeting)
        {
            MakeGreeting(name);
        }
        static void Main(string[] args)
        {
            string s1 = "KDW", s2 = "万锴迪";
            GreetDelegate delegate1 = new GreetDelegate(EnglishGreeting);
            delegate1+=ChineseGreeting;
            GreetPeople(s1,EnglishGreeting);
            GreetPeople(s2,ChineseGreeting);
            Console.WriteLine();
            GreetPeople(s1, delegate1);
            Console.ReadKey();
        }
    }
}
