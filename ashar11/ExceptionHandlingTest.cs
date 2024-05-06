using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ashar11
{
    internal class ExceptionHandlingTest
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b;
                Console.WriteLine("Enter value for a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value for b: ");
                b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;
                Console.WriteLine("The value of c is : " + c);
                int[] arr = {3, 5, 6};
                Console.WriteLine(arr[4]);
            }
            catch(DivideByZeroException e1) 
            {
                Console.WriteLine(e1.ToString());
            }
            catch (IndexOutOfRangeException e2)
            {
                Console.WriteLine(e2.ToString());

            }

            finally { 
                Console.WriteLine("End of program");
            }
            Console.ReadLine();
        }
    }
}
