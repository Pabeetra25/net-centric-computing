using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ashar11
{
    public class DelegatesDemo
    {
        public delegate void SimpleDelegate();

        static void Main(string[] args)
        {
            SimpleDelegate d=new SimpleDelegate(F1);
            d();
            Console.ReadKey();
          
        }
        static void F1()
        {
            Console.WriteLine("i was called by delegate");
        }
    }
}