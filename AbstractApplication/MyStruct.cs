using System;
namespace DemoProject
{
    struct MyStruct
    {
        int i;
        public MyStruct(int i)
        {
            this.i = i;
        }
        public void Display()
        {
            Console.WriteLine("Method in a Structure "+i);
        }
        static void Main(string[] args)
        {
            MyStruct m1;
            m1.i = 12;
            m1.Display();
            MyStruct m2 = new MyStruct();
            m2.Display();
            MyStruct m3= new MyStruct(33);
            m3.Display();
            Console.ReadLine();
        }
    }
}