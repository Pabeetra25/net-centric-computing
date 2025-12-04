using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace diffVariables
{
    internal class Program
    {
        int x ;  //Non-static
        static int y = 78;  //Static 
        const float pi = 3.14f;//behavior of 'const' variable is similar to the behavior of 'static' variable..the only differnece
        //between a static and constant variable is static variables can be modified whereas const variable can't be modified
        readonly bool flag;
        public Program(int x,bool flag)//instance/non-static variables also can be initialized through constructor calling
        {
            this.x = x;
            this.flag = flag;
        }

        static void Main(string[] args)
        {
            //the memory for that y doesnot require instance of a class..the reason is that the static variable is initialized immediately once the execution of the class starts
            Console.WriteLine("Value of y is " + y);
            Console.WriteLine("Value of pi is " +pi);
            Program p = new Program(34,true); 
            // but the memory for that x is going to allocated only if we created the instance of the classs
            Program p2 = new Program(12,false);
            Console.WriteLine("Value of x is "+ p.x+" and " +p2.x);
            Console.WriteLine("Value of flag is " +p.flag + " and "+ p2.flag);

            // p.x = 333;->no error because non-static variables can be modified
           // p.flag = false;->error occurs because  readonly variables can not be modified

            Console.ReadLine();
        }
    }
}
