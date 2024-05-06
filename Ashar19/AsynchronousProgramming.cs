using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashar19
{
    internal class AsynchronousProgramming
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.ReadLine();


        }
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Method1");
                }
            });
        }
        public static void Method2()
        {
            for(int i = 0;i < 25;i++) {
                Console.WriteLine("Method2");

            }
        }

    }
}
