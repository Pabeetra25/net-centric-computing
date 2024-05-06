using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ashar11
{
   
    public class InheritanceTest
    {
        static void Main(string[] args)
        {
            ChildCLass cc=new ChildCLass();
            cc.Print();
            
            Console.ReadLine();
        }

    }
    public class ParentClass
    {
        public int x = 90;
        public ParentClass()
        {

            Console.WriteLine("Parent Constructor");

        }
        public void Print()
        {
            Console.WriteLine("This is parent class");
        }
    }
    public class ChildCLass : ParentClass
    {
        public ChildCLass() : base()
        {
            Console.WriteLine("Child Constructor");
            base.Print();
            Console.WriteLine(base.x);
        }

    }
}
