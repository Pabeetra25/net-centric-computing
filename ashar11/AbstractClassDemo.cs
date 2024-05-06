using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ashar11
{
    public abstract class Abs
    {
        public abstract void AbstractMethod();
        public void NonAbstractMethod()
        {
            Console.WriteLine("This is non-Abstract method");
        }
        class Derived : Abs
        {
            public override void AbstractMethod()
            {
                Console.WriteLine("Overriding Abstract method in derived class");
            }
        }
        public class AbstractClassDemo
    {
       

            static void Main(string[] args)
            {
                Derived d = new Derived();
                d.NonAbstractMethod();
                d.AbstractMethod();
                Console.ReadLine();

            }

        }
    }
    
}
