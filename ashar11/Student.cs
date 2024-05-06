using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ashar11
{
    //indexer example
    public  class Student
    {
        private int roll;
        public int Roll
        {
            get
            {
                return roll;
            }
            set { roll = value; }
        }
        private int[]Marks=new int[3];
        public int this[int index]
        {
            get { return Marks[index]; }
            set { Marks[index] = value; }

        }
        public double GetPercent()
        {
            double total = 0.0;
            foreach (int m in Marks)
            {
                total += (double)m;

            }
            return total/Marks.Length;
        }
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Roll = 1;
            s1[0] = 34;
            s1[1] = 45;
            s1[2] = 67;
            Console.WriteLine(s1.GetPercent());

            Student s2 = new Student();
            s2.Roll = 2;
            s2[0] = 45;
            s1[1] = 55;
            s1[2] = 67;
            Console.WriteLine(s2.GetPercent());
            Console.ReadLine();

        }
    }
}
