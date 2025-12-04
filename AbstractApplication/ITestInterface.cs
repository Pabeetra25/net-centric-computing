using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractApplication
{
    interface ITestInterface1
    {
        void Add(int a, int b);
    }
    interface ITestInterface2:ITestInterface1
    { 
     void Sub( int a,int b);
    }
    class ImplementationClass : ITestInterface2
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Main(string[] args)
        {
            ImplementationClass obj = new ImplementationClass();
            ITestInterface2 i=obj; //calling by reference
            //  obj.Add(21, 92); obj.Sub(1345, 233);
            i.Add(21, 92); i.Sub(1345, 233);
            Console.ReadLine();
        }
    }
}
