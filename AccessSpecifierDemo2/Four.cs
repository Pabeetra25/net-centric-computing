using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifierDemo2
{
    //CASE4:consumuing members of a class from child class of different project
     class Four:AccessSpecifierDemo.Program
    {
        static void Main(string[] args)
        {
            Four f=new Four();
            f.Test3();f.Test4();f.Test5();
            Console.ReadLine();
        }
    }
}
