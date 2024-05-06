using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    abstract class AbsParent
    {
        public void Add(int x, int y) 
        {
            Console.WriteLine(x + y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public abstract void Mul(int x, int y);
        public abstract void Div(int x, int y);
        static void Main(string[] args)
        {
        //AbsParent parent = new AbsParent();->cannot create instance of an abstract class
        }
    }
}
