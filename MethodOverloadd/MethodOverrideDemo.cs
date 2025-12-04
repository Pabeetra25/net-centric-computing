using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadd
{
    internal class MethodOverrideDemo
    {
        class LoadParent
        {
            public void Show()
            {
                Console.WriteLine("Parent's Show Method is called");
            }
            public virtual void Test()  //overridable
            {
                Console.WriteLine("Parent's Test Method is called");
            }
        }
        class LoadChild:LoadParent 
        {
            //overloading parent's Show method in child  class
            public void Show(int i)
            {
                Console.WriteLine("Child's Show Method is called "+i);
            }
            //overriding parent's Test method in child class
            public override void Test()//overriding
            {
                Console.WriteLine("Child's Test method is called");
            }
            static void Main(string[] args)
            {
                LoadChild c=new LoadChild();
                c.Show();
                c.Show(5);
                c.Test();
                Console.ReadLine();
            }
        }

       
    }
}
