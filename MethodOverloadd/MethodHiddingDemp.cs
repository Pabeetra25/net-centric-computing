using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadd
{
    internal class MethodHiddingDemo
    {
        class ParentClass
        {
            public virtual void Test1()
            {
                Console.WriteLine("Method Test1 from Parent class.");
            }
            public void Test2()
            {
                Console.WriteLine("Method Test2 from parent classs.");

            }
        }


        class ChildClass : ParentClass
        {
            public override void Test1()//method overriding
            {
                Console.WriteLine("Method Test1 from child classs.");
            }
            public new void Test2()//method hiding/shadowing
            {
                Console.WriteLine("Method Test2 from child class");
            }
            public void ParentTest1()
            {
                base.Test1();
            }
            public void ParentTest2()
            {
                base.Test2();
            }
            static void Main(string[] args)
            {
                /* ParentClass p=new ParentClass();
                 p.Test1();
                 p.Test2();  */
                /* ChildClass c = new ChildClass();
                c.ParentTest1();
                c.ParentTest2();
                c.Test1();
                c.Test2();  */
                ChildClass c = new ChildClass();//c is instance of child class
                ParentClass p = c;//p is a reference of parent class created by using child instances
                p.Test1();//invokes child classes method

                p.Test2 ();//invokes parent classes method
                Console.ReadLine();
                }
        }

    }

}
