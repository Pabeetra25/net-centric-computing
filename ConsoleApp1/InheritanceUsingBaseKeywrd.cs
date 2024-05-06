using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class InheritanceUsingBaseKeywrd
    {
        public class Parent
        {
            public int x = 34;
            public Parent()
            {
                Console.WriteLine("Parent constructor");
            }
            public void Print()
            {
                Console.WriteLine("This is parent Class");
            }
        }
        public class Child : Parent
        {
            public Child() : base()
            {
                Console.WriteLine("Child Constructor");
                base.Print();
                Console.WriteLine(base.x);

            }

            static void Main(string[] args)
            {
                Child child = new Child();
                child.Print();
                Console.ReadLine();

            }
        }
    }
}
