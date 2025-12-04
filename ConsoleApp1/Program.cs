using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter for n:");
            int n=Convert.ToInt32(Console.ReadLine());
            if(n>0 )
            {
                Console.WriteLine("greater than zero");
            }
            else if(n<0)
            {
                Console.WriteLine("smaller than 0");
            }
            else { Console.WriteLine("Equal to zero"); }
            Console.ReadLine();
        }
    }
}
