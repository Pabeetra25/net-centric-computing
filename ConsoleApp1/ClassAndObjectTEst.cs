using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {
        public int x,y;
        public void Show()
        {
            Console.WriteLine("x:" + x);
            Console.WriteLine("y: " + y);
        }
    }
     class ClassAndObjectTEst
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.x = 12;
            p.y=13;
            p.Show();
            Console.ReadKey();

        }
    }
}
