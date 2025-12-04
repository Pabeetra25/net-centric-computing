using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractApplication
{
    public  class TestCustomer
    {
        static void Main(string[] args)
        {
            Customer obj=new Customer(101,false,"Subhman",5000.00,"Kathmandu");
            Console.WriteLine("Custid: "+obj.Custid);
            //obj.Custid=102;//can not be assigned as the property is read only
            if (obj.Status == true)
                Console.WriteLine("Current Customer Status: Active"); 
            else
                Console.WriteLine("Current Customer Status: In-Active ");
            
            
           
            Console.WriteLine("Customer Name: " + obj.Cname);
            obj.Cname += "Radha";//Assignment failed,so below statement prints old name only
            Console.WriteLine(" Modified Customer Name: " + obj.Cname);
            Console.WriteLine("Customer Balance: " + obj.Balance);
            obj.Balance -= 3000;//Assignment failed,so below stmt print old balance only
            Console.WriteLine("Customer modified Balance: " + obj.Balance);
            obj.Status = true;
            if (obj.Status == true)
                Console.WriteLine("Current Customer Status: Active");
            else
                Console.WriteLine("Current Customer Status: In-Active ");
            obj.Cname += "Radha";//Assignment succed,so below statement prints new name 
            Console.WriteLine(" Modified Customer Name: " + obj.Cname);
            obj.Balance -= 3000;//Assignment succed,so below stmt print  new balance 
            Console.WriteLine("Customer modified Balance: " + obj.Balance);
            obj.Balance = obj.Balance - 1600;//assignment fails,so prints u with old value
            Console.WriteLine("Balance when assignment failed: " + obj.Balance);
            obj.Balance = obj.Balance - 1400;//assignment succeds,so prints new value
            Console.WriteLine("Balance when assignment succeed: " + obj.Balance);
            Console.BackgroundColor = ConsoleColor.Blue;


            Console.WriteLine("Current City :"+ obj.City);
            obj.City = "Kirtipur";
            Console.WriteLine("Modified City :" + obj.City);



            Console.ReadLine();         }
    }
}
