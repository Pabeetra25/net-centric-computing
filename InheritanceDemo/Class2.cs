using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
     class Class2:Class1
    {
         Class2()
        {
            Console.WriteLine("class 2 constructor is called");
        }
        public void Test3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main(string[] args)
        {
            Class2 c = new Class2();
            c.Test1();
            c.Test2();c.Test3();
            Console.ReadLine();

        }

   

    }
}
