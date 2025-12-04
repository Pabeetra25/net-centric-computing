using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractApplication
{
     class PropertyDemo
    {
        public class Circle
        {
            double _Radius = 45.86;
            /*  public double GetRadius()//provides only get access to the value
             {
                 return Radius;
             }
             public void SetRadius(double value)//provides only set access to the value
             {
                 Radius=value;
             }  */
            public double Radius
            {
                get { return _Radius; }//represents a value returning method without parameter
                set
                {
                    if(value >_Radius)

                    _Radius = value;
                       
                }//represents a non-value returning method with parameter
            }
        }

        public class TestCircle
        {
            static void Main(string[] args)
            {
                Circle c=new Circle();
                double radius = c.Radius;
                c.Radius = 56.89;
                Console.WriteLine("Value of Radius is "+c.Radius);
                Console.ReadLine();



            }

        }
    }
}
