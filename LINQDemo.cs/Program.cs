using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo.cs
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 45, 67, 42, 12, 87, 34, 56, 13, 34, 23, 98, 65, 12, 43, 18, 9, 4, 5, 32, 56 };
            var brr=from i in arr where i>40 orderby i descending select i;
           
            foreach(int x in brr) 
            
                Console.WriteLine(x+ " ");
                Console.ReadLine();
            
        }
    }
}
