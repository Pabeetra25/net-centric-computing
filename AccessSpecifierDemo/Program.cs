using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifierDemo
{
    //CASE1:consuming members of a class from same class of same project
    public class Program
    {
        
        private void Test1()

        {
            Console.WriteLine("Private Method");

        }
        internal void Test2()
        {
            Console.WriteLine("Internal Method");
        }
        protected void Test3()
        {
            Console.WriteLine("protected Method");
        }
        protected internal void Test4()
        {
            Console.WriteLine("protected internal Method");
        }
        public void Test5()
        {
            Console.WriteLine("Public Method");
        }
        static void Main(string[] args)
        {
            Program p= new Program();
            p.Test1();p.Test2();p.Test3();p.Test4();
            p.Test5();
            Console.ReadLine();


        }
    }
}
