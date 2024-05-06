using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashar19
{
    internal class List
    {
        static void Main(string[] args)
        {
            List<string>names = new List<string>();
            names.Add("Sara");
            names.Add("dipika");
            names.Add("sona");
            Console.WriteLine(names.IndexOf("Sara"));
            Console.WriteLine(names.Count);



            names.RemoveAt(2);
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
