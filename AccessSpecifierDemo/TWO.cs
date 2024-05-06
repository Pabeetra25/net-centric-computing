using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifierDemo
{
     class TWO:Program
    {
        //CASE2:consuming members of a class from child class of same project
        static void Main(string[] args)
        {
            TWO t= new TWO();
            t.Test2();t.Test3();t.Test4();t.Test5();
            Console.ReadLine();
        }
    }
}
