using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProject
{
     class TestEmployee
    {
        static void Main(string[] args)
        {
            Employee Emp=new Employee(1001,"Speed","Manager",20000,"Sales","Hawai");
            Console.WriteLine("Eno :" +Emp[1]);
            Console.WriteLine("Ename:" + Emp[2]);
            Console.WriteLine("Job :" + Emp[3]);
            Console.WriteLine("Salary :" + Emp[4]);
            Console.WriteLine("Dname:" + Emp[5]);
            Console.WriteLine("Location :" + Emp[6]);

            
            Emp[3] = "Sr.Manager";
            Emp[4] = 40000.00;
            
            Console.WriteLine();
            Console.WriteLine("Eno :" + Emp["Eno"]);
            Console.WriteLine("Ename:" + Emp["Ename"]);
            Console.WriteLine("Job :" + Emp["Job"]);
            Console.WriteLine("Salary :" + Emp["Salary"]);
            Console.WriteLine("Dname:" + Emp["Dname"]);
            Console.WriteLine("Location :" + Emp["Location"]);
            Console.ReadLine();

        }
    }
}
