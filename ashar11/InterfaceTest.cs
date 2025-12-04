using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ashar11
{
    interface IFace1
    {
        void Method1();
    }

    class Parent1
    {
        public void PMethod1()
        {
            Console.WriteLine("Method from parent1");
        }
    }
    class Child1 : Parent1,IFace1  //,IFace2
    {
        public void Method1()
        {
            Console.WriteLine("Implementing method1 from Interface IFace1");
        }
    }
    public class InterfaceTest
    {
        static void Main(string[] args)
        {
            Child1 c1= new Child1();
            c1.Method1();
            c1.PMethod1();
            Console.ReadLine();
        }
    }
    
}
