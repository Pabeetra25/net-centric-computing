using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ashar11
{
    internal class ArrayDemo
    {
        static void Main(string[] args)
        {
            int[] arr = { 34, 56, 78, 54 };
            int i;
            for ( i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}]is { 1}", i, arr[i]);
            }
            int sum = 0;

            foreach (int j in arr)
            {
                sum += j;
                Console.WriteLine(i);
            }
                Console.WriteLine("the sum is " + sum);
            
            Console.ReadLine();
        }
        

    }
}
