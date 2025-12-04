using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ashar11
{
    internal class LoopingDemo
    {
        static void Main(string[] args)
        {

            //FOR loop
            /* int i ;
             Console.WriteLine("Starting loop");
             for (i = 0; i < 10; i++)

                 Console.WriteLine(i);
                 i++;
             Console.WriteLine("End of loop");  */

            int i = 3;
            Console.WriteLine("Starting loop");
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("End of loop");

            Console.ReadLine();
        }
    }
}
