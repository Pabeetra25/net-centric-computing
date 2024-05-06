using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashar19
{
    internal class LambdaExpression
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>() { 2, 4, 6, 8, 10 };
            var  squares =  Numbers.Select (s => s * s);
            Console.WriteLine("Squares: ");
            foreach (var value in squares) 
                Console.WriteLine("{0}",value);
                Console.ReadLine();
            
        }
    }
}
