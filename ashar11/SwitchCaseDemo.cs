﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ashar11
{
    internal class SwitchCaseDemo
    {
        static void Main(string[] args)
        {
            int day = 1;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                 case 3:
                    Console.WriteLine("Tuesday");
                    break;
                  case 4:
                    Console.WriteLine("Wednesday");
                    break;

                 case 5:
                    Console.WriteLine("Thursady");
                    break;
                  case 6:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }

        }
    }
}
