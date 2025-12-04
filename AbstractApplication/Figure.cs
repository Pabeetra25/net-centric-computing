using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractApplication
{
        public abstract class Figure
        {
            public double width, height, radius;
            public const float pi = 3.14f;
            public abstract double GetArea();
        }
        public class Rectangle : Figure
        {
            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;

            }
            public override double GetArea()
            {
                return width * height;
            }
        }
        public class Circle : Figure
        {
            public Circle(double radius)
            {
                this.radius = radius;
            }
            public override double GetArea()
            {
                return pi * radius * radius;
            }
        }
        public class Triangle : Figure
        {
            public Triangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }
            public override double GetArea()
            {
                return 0.5 * width * height;
            }
        }
        public class Cone : Figure
        {
            public Cone(double radius, double height)
            {
                this.radius = radius;
                this.height = height;
            }
            public override double GetArea()
            {
                return pi * radius * (radius + Math.Sqrt(height * height + radius * radius));
            }


        }
        class TestFigures
        {
            static void Main(string[] args)
            {
                Rectangle r = new Rectangle(12.45,34.56);
                Circle c = new Circle(45.56);
                Cone c0 = new Cone(34.98,12.98);
                Triangle t = new Triangle(34.33, 56.78);
                Console.WriteLine("Area of rectangle " + r.GetArea());
                Console.WriteLine("Area of circle "+c.GetArea());
                Console.WriteLine("Area of Cone " + c0.GetArea());
                Console.WriteLine("Area of Triangle "+t.GetArea());
                Console.ReadLine();
            }
        }

    }
  

