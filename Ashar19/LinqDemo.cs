using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashar19
{
    internal class LinqDemo
    {
        public class Student
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
            public int StudentAge { get; set; }
            static void Main(string[] args)
            {
                List<Student> students = new List<Student>()
                {
                    new Student() { StudentId = 1,StudentName="Sana",StudentAge=20},
                    new Student() {StudentId = 2,StudentName="Saxara",StudentAge=18},
                     new Student() { StudentId =3,StudentName="mansna",StudentAge=12},
                    new Student() {StudentId = 4,StudentName="Saara",StudentAge=28},
                    new Student() {StudentId = 5,StudentName="rara",StudentAge=13},
                    new Student() {StudentId = 6,StudentName="manvi",StudentAge=28}
                };
                var TeenAge=from s in students where s.StudentAge>12 && s.StudentAge<22 select s;
                foreach ( Student item in TeenAge)
                    Console.WriteLine(item.StudentName);

                Console.WriteLine("---------------------------");
                List<string> Courses = new List<string>()
                {
                    "C# Tutorials","C Tutorials","Java Tutorials","Dart","Flutter"
                };
                // var result=from s in Courses where (s.Contains("Tutorials"))select s; //linq Query syntax
                //or
                var result = Courses.Where(s => s.Contains("Tutorials"));//linq method syntax
                foreach(string s in result) Console.WriteLine(s);
                Console.ReadLine();
                



            }
        }
    }
}
