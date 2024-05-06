using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProjects
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
    }
    class TestEmployee
    {
        static void Main(string[] args)
        { 
            List<Employee> Employees = new List<Employee>();
            Employees.Add(new Employee { Id=101,   Name="Raju",      Job="Manager",    Salary=  26000.00});
            Employees.Add(new Employee { Id = 102, Name = "Rakshya", Job = "Analyst",  Salary = 26000.00 });
            Employees.Add(new Employee { Id = 103, Name = "Ramba",   Job = "Salesman", Salary = 45000.00 });
            Employees.Add(new Employee { Id = 104, Name = "Rajan",   Job = "SalesMan", Salary = 76000.00 });
            Employees.Add(new Employee { Id = 105, Name = "Rakesh",  Job = "Salesman", Salary = 24000.00 });
            Employees.Add(new Employee { Id = 106, Name = "Ranju",   Job = "Clerk",    Salary = 86000.00 });

            foreach (Employee emp in Employees)
                Console.WriteLine(emp.Id+ " "+emp.Name + "   "+emp.Job+"    "+emp.Salary);
                Console.ReadLine(); 
            

        }
    }
}
