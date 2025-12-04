using System;

class Shape
{
    public virtual double GetArea()
    {
        return 0;
    }
}

class Triangle: Shape
{
    private double width;
    private double height;

    public Triangle(double width,double height)
    {

        this.width = width;
        this.height = height;
    }

    public override double GetArea()
    {
        return (width * height)/2;
    }
}
class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : Shape
{
    private double width;
    private double height;

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

class Program
{
    static void DisplayArea(Shape shape)
    {
        double area = shape.GetArea();
        Console.WriteLine($"Area: {area}");
    }

    static void Main(string[] args)
    {
        Triangle t=new Triangle(4,8);
        Circle circle = new Circle(13);
        Rectangle rectangle = new Rectangle(3, 8);

        DisplayArea(t);
        DisplayArea(circle);
        DisplayArea(rectangle);
        Console.ReadKey();
    }
}
