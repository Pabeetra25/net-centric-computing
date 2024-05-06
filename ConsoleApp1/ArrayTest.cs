using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ArrayTest
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 1, 14 };
            for(int i=0;i<arr.Length; i++)
            {
                Console.WriteLine("arr[{0}]={1}", i, arr[i]);

            }
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
               
            }
            Console.WriteLine("the sum is :" + sum);
            Console.ReadKey();
        }
    }
}
