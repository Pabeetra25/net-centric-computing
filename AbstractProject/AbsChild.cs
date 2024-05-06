using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{


     class AbsChild:AbsParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x*y);
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine(x/y);
        }
        static void Main(string[] args)
        {
            AbsChild c = new AbsChild();
            AbsParent p = c;
           
            p.Add(45, 34);
            p.Sub(344, 56);
            p.Mul(1, 2);
            p.Div(45, 3);
            Console.ReadLine();
        }
    }
}
