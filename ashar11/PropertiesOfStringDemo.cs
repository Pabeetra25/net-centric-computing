using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ashar11
{
    internal class PropertiesOfStringDemo
    {
        static void Main(string[] args)
        {
            string s = "Encyclopedia";
            Console.WriteLine("Length : "+s.Length);
            Console.WriteLine("IndexOF: " + s.IndexOf("pe"));
            Console.WriteLine("Lowercase: " + s.ToLower());
            Console.WriteLine("Uppercase : " + s.ToUpper());
            Console.WriteLine("Substring "+s.Substring(0,4));
            Console.ReadLine();
        }
    }
}
