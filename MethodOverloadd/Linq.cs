using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public string Department { get; set; }
}

class Program
{
    static void Main()
    {
        // Create a list of students
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Department = "CSIT" },
            new Student { Name = "Bob", Department = "ECE" },
            new Student { Name = "Charlie", Department = "CSIT" },
            new Student { Name = "David", Department = "ME" },
            new Student { Name = "Eve", Department = "CSIT" },
        };

        // Select students whose department is "CSIT"
        var csitStudents = students.FindAll(student => student.Department == "CSIT");

        // Print the selected students
        Console.WriteLine("Students in CSIT department:");
        foreach (var student in csitStudents)
        {
            Console.WriteLine($"Name: {student.Name}, Department: {student.Department}");
        }
    }
}
