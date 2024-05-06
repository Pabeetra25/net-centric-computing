using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractApplication
{
    public enum Days:byte
    {
        Monday=1, Tuesday=11, Wednesday=21, Thursday=31,
        Friday=41
    }
    class TestClass
    {
        public static Days MeetingDays
        {
            get; set;
        } = 0;
       
        static void Main(string[] args)
        {
            
          Console.BackgroundColor = ConsoleColor.Magenta;
            // Days d = 0;
            //Days d1= Days.Wednesday;
            // Console.WriteLine(d);
            //Console.WriteLine(d1);
            /* foreach (byte i in Enum;.GetValues(typeof(Days)))

               Console.WriteLine(i+ ":"+(Days)i);
             foreach (string s in Enum.GetNames(typeof(Days)))

                 Console.WriteLine(s);

                 */

            Console.WriteLine(MeetingDays);
            MeetingDays = Days.Wednesday;
            Console.WriteLine(MeetingDays);
            Console.ReadLine();
        }
    }
}
