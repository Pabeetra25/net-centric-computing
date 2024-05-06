using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SwitchCase2
    {
        static void Main(string[] args)
        {
            int day = 2;
            switch (day)
            {
                case 1:
                    Console.WriteLine("sunday");
                    break;
                case 2:
                    Console.WriteLine("monday");
                    break;
                 case 3:
                    Console.WriteLine("tuesdY");
                    break;

                 default:
                    Console.WriteLine("invalid input");
                    break;
            }
            Console.ReadLine();
        }
    }
}
