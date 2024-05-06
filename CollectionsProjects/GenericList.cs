using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProjects
{
    internal class GenericList
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(10);li.Add(40);li.Add(60);li.Add(50);
            li.Add(20);li.Add(30);
            li.Sort();


            for(int i=0;i<li.Count;i++)
                Console.Write(li[i] + " ");
                 Console.WriteLine();

             li.Insert(4, 45);
             foreach(int i in li)
               Console.Write(i+" ");
               Console.WriteLine();

                li.RemoveAt(2);
                foreach(int i in li)
                Console.Write(i+" ");
                Console.WriteLine();
                
            Console.ReadLine();
        }
       
    }
      
    
}
