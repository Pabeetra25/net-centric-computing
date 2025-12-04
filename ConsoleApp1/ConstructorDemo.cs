using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class point3
    {
        public int x;
        public int y;
        public point3() { }
        public point3(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Show()
        {
            Console.WriteLine("X:" + x);
            Console.WriteLine("Y:" + y);
        }
    }
     class ConstructorDemo
    {
        static void Main(string[] args)
        {
            point3 p = new point3();
            p.x = 98;
            p.y = 1;
            p.Show();
            point3 p1= new point3(45,76);
            p1.Show();
            Console.ReadLine();

        }
    }
}
