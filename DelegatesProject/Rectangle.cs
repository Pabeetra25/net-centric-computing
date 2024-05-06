using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProject
{
    public delegate void RectDelegate(double Width,double Height);//defining a delegate
     class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area of  Rectangle is "+Width * Height);
            
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Perimeter of Rectangle is "+2*(Width + Height));
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            // rect.GetArea(12.34, 56.78);
            // rect.GetPerimeter(12.34, 56.78);
           // RectDelegate obj = new RectDelegate(rect.GetArea);..Also can be as below
            RectDelegate obj = rect.GetArea;
            obj += rect.GetPerimeter;
            obj.Invoke(12.34,56.78);
            Console.WriteLine();
            obj.Invoke(47.87, 34.89);
            Console.ReadLine();
        }
    }
}
