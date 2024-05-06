using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FunctionOverloading
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minimum number is: " + Min(34, -23));
            Console.WriteLine("Minimum string is: " + Min("Radha","PArwea"));
            Console.ReadLine();
        }
        static int Min(int n1,int n2)
        {
            if (n1 < n2)
            
                return n1;
            
            else
            
                return n2;
            
        }
        static string Min(string s1,string s2)
        {
            if (s1.CompareTo(s2) < 0)
            
                return s1;
            else return s2;
            
        }
    }
}
