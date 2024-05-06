using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProject
{
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(string str);
    public  class Program
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static string SayHello(string name)
        {
            return "Hello  " + name;
        }

        static void Main(string[] args)
        {
            Program p= new Program();
            // p.AddNums(12, 67);
            AddDelegate ad = new AddDelegate(p.AddNums);
            ad(122, 67);//or  ad.Invoke(23, 44);


            SayDelegate ad2 = new SayDelegate(SayHello);
            string str = ad2("Fahaman");//or =ad2.invoke("raj");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
