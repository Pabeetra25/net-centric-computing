using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}

class LambdaExp
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, DepartmentId = 101, Name = "Suraj", Address = "Tamghas-Gulmi" },
            new Student { Id = 2, DepartmentId = 102, Name = "Sujan", Address = "Ghorai-Dang" },
            new Student { Id = 3, DepartmentId = 101, Name = "Sudharson", Address = "tansen-palpa" },
            new Student { Id = 4, DepartmentId = 103, Name = "Sudeep", Address = "Devinagar-Butwal" },
            new Student { Id = 5, DepartmentId = 101, Name = "Sanjeet", Address = "Tamghas-Gulmi"}
        };

        int filterDepartmentId = 101;

        // Using Lambda expression to filter students by department ID
        var filteredStudents = students.Where(student => student.DepartmentId == filterDepartmentId).ToList();

        Console.WriteLine($"Students in Department with ID {filterDepartmentId}:");

        foreach (var student in filteredStudents)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Address: {student.Address}");
            
        }
        Console.ReadLine();
    }
}
