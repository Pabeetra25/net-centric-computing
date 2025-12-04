using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifierDemo2
{
    //CASE5:consuming member of a class from non-child class of different project
    internal class Five
    {
        static void Main(string[] args)
        {
            AccessSpecifierDemo.Program p = new AccessSpecifierDemo.Program();
            p.Test5();
            Console.ReadLine();
        }
    }
}
