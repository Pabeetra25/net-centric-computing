using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ashar11
{
    public  class IfElseDemo
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter n:");
            n=Convert.ToInt32(Console.ReadLine());
            string res = "";
            if (n > 0)
                res = "Greater than Zero";
            else if (n < 0)
               res="Number is les than 0";
            else
                res="Equal to zero";
            Console.WriteLine(res);
            Console.ReadLine();

        }
          
    }
}
