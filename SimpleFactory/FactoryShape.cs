using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory
{
    internal class FactoryShape
    {
        public IShapeCal GetShape(string type)
        {
            IShapeCal obj = null;
            if(type.Equals("R"))
            {
                double l, w;
                Console.Write("Enter Length: ");
                l = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Width: ");
                w = Convert.ToDouble(Console.ReadLine());

                obj = new Rectangle(l, w);
              
            }
            else if(type.Equals("S")) 
            {
                double s;
                Console.Write("Enter side length: ");
                s = Convert.ToDouble(Console.ReadLine());

                obj = new Square(s);
            }
            else  if(type.Equals("C"))
            {
                double r;
                Console.Write("Enter radius: ");
                r = Convert.ToDouble(Console.ReadLine());

                obj = new Circle(r);
            }
            else if (type.Equals("T"))
            {
                double hei, bas;
                Console.Write("Enter Height: ");
                hei = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Base: ");
                bas = Convert.ToDouble(Console.ReadLine());

                obj = new Triangle(hei, bas);
            }
            return obj;
            
        }
    }
}
