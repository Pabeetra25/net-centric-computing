using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point2
    {
        private int x;
        private int y;
        public int X
        {
            get
            {
                return x;
            }
            set { x = value;}
        }
        public int Y
        {
            get { return y;}
            set { y = value;}
        }
        public void Show()
        {
            Console.WriteLine("X:"+ x);
            Console.WriteLine("Y:"+ y);
        }
    }
  
       
    class ClassDEmo
    {
        static void Main(string[] args)
        {
            Point2 p2 = new Point2();
            p2.X = 10;
            p2.Y = 20;
            p2.Show();
            Console.ReadLine();

        }
    }
}
