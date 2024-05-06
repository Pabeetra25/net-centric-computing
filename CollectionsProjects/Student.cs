using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProjects
{
    public  class Student:IComparable<Student>
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }

        public int CompareTo(Student other)
        {
           if(this.Sid>other.Sid)
                return 1;
           else if(this.Sid<other.Sid)
                return  -1;
           else return 0;
        }
    }
    class TestStudent
    {
        static void Main(string[] args)
        {
            Student s1 = new Student { Sid = 103, Name = "Suraj     ", Class = 10, Marks = 533.00f };
            Student s2 = new Student { Sid = 104, Name = "Sujan     ", Class = 10, Marks = 514.00f };
            Student s3 = new Student { Sid = 106, Name = "Sudharson ", Class = 10, Marks = 413.00f };
            Student s4 = new Student { Sid = 108, Name = "Subhman   ", Class = 10, Marks = 473.00f };
            Student s5 = new Student { Sid = 109, Name = "Sudhan    ", Class = 10, Marks = 546.00f };
            Student s6 = new Student { Sid = 101, Name = "Serlock   ", Class = 10, Marks = 578.00f };

            List<Student> Students= new List<Student>() { s1, s2, s3, s4, s5, s6 };
            Students.Sort();
            foreach (Student S in Students) 
            {
                Console.WriteLine(S.Sid + " " + S.Name + "     " + S.Class + "    " + S.Marks);

            }
            Console.ReadLine();
        }
    }
}
