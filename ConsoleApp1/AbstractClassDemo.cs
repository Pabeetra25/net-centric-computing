using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
     class AbstractClassDemo
    {
        static void Main(string[] args)
        {
            de
          
            d.AbstractMethod();
            d.NonAbstractMethod();
            Console.ReadLine();


        }
    }
    abstract class AbsClass
    {
        public abstract void AbstractMethod();
        public void NonAbstractMethod()
        {
            Console.WriteLine("Non-abstract method ");
        }
        class Derived : AbsClass
        {
            public override void AbstractMethod()
            {
                Console.WriteLine("overriding abstract method in derived class");
            }

        }
    }

}

