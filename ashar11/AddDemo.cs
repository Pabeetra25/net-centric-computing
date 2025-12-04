using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ashar11
{
    internal class AddDemo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n1:");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter n2:");
            int n2=Convert.ToInt32(Console.ReadLine());
            int sum=n1 + n2;
            Console.WriteLine("The sum of {0} and {1} is {2}",n1,n2,sum);
            Console.WriteLine("The sum of " + n1 + " and " + n2+ " is " +sum);
            Console.WriteLine("the sum is " + sum);
            Console.ReadKey();

        }
    }
}
