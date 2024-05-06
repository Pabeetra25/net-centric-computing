using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicals
{
    internal class Exceptionhandling
    {
        

class Program
    {
        static double GetPrice()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter the price: ");
                    double price = double.Parse(Console.ReadLine());
                    return price;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid numeric price.");
                }
            }
        }

        static void Main(string[] args)
        {
            double price = GetPrice();
            Console.WriteLine("Price: " + price);
                Console.ReadLine();
        }
    }

}
}
