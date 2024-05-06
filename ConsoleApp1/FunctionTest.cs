using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FunctionTest
    {
        static void Main(string[] args)
        {
            F1();
            int sq = Square(25);
            Console.WriteLine("Square :" +sq);
            Console.ReadKey();

        }
        static void F1()
        {
            Console.WriteLine("This is function F1");
        }
        static int Square(int n)
        {
            return n * n;
        }
        
    }
}
