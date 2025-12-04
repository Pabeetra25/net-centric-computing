using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StringTest
    {
        static void Main(string[] args)
        {
            //String is used for storing and manipulating text.String variables contain zero or more characters with in the double quotes.
            string s = "Javascript";
            Console.WriteLine("Length: "+s.Length);
            Console.WriteLine(s.IndexOf("va"));
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.Substring(1,5));
            Console.ReadLine();

        }
    }
}
