using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProject
{
    public delegate string GreetingsDelegate(string name);//defining delegate
     class LambdaExpression
    {
        public static string Greetings(string name)
        {
            return "Hello " + name + ", a very Good Morning!";
        }
        static void Main(string[] args)
        {
            GreetingsDelegate obj=new GreetingsDelegate(Greetings);//process of instantating delegate
            string str = obj.Invoke("Shuvman");//calling the dleegate
            Console.WriteLine(str);
            Console.ReadLine();

        }
     

    }
}
