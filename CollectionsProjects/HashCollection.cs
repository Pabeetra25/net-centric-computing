using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProjects
{
    public class HashCollection
    {

        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Eid", 1010);
            ht.Add("Ename", "Scoot");
            ht.Add("Job", "Manager");
            ht.Add("Salary", 250000.00);
            ht.Add("MgrId", 101);
            ht.Add("Phone", 12344556);
            ht.Add("Email", "Scoot@gmail.com");
            ht.Add("Dname", "Sales");
            ht.Add("Location", "Kathmandu");

            //Console.WriteLine(ht["Email"]);
            foreach (object key in ht.Keys)
                Console.WriteLine(key +": "+ht[key]);
            Console.ReadLine();
        }
    }
}
