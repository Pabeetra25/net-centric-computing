using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class IndexerDemo
    {
        public class Student
        {
            private int roll;
            public int Roll
            {
                get { return roll; }
                set { roll = value; }
            }
            private int[] Marks = new int[3];
            public int this[int index]
            {
                get { return Marks[index]; }
                set { Marks[index] = value;}
            }
            public double GetPercent()
            {
                 double total=0.0;
                foreach (int i in Marks)
                {
                    total +=i;
                }
                return total/Marks.Length;

            }
        }

        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Roll = 1;
            s1[0] = 34;
            s1[1] = 56;
            s1[2] = 78;
            Console.WriteLine(s1.GetPercent());
            Student s2 = new Student();
            s2.Roll = 2;
            s2[0] = 64;
            s2[1] = 86;
            s2[2] = 78;
            Console.WriteLine(s2.GetPercent());
            Console.ReadLine();
        }
    }
}
