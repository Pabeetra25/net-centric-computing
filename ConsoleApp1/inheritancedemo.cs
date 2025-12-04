using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class InheritanceTEst_cs
    {
        public class ParentClass
        {
            public ParentClass()
            {
                Console.WriteLine("Parent Constructor");
            }
            public void Print()
            {
                Console.WriteLine("THis is parent class");

            }

            public class ChildClass : ParentClass
            {
                public ChildClass()
                {
                    Console.WriteLine("Child Constructor");
                }
                public void print1()
                {
                    Console.WriteLine("This is child constructor");
                }
            }
            static void Main(string[] args)
            {
                ChildClass c = new ChildClass();
                
                c.Print();
                c.print1();

                Console.ReadLine();

            }
        }

    }
}