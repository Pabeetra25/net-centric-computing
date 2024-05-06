using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadd
{
    class Program
    {
        public void Test()
        {
            Console.WriteLine("Method 1");

        }
        public void Test(int i)
        {
            Console.WriteLine("Method 2");

        }
        public void Test(string s)
        {
            Console.WriteLine("Method 3");

        }
       
        static void Main(string[] args)
            {
                Program p=new Program();
                p.Test();
                p.Test("Subhman");
                p.Test(10);
               
                Console.ReadLine();
            }
        }
    
}
