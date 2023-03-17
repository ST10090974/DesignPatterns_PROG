using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory
{
    internal class Triangle: IShapeCal
    {
        private double hei, bas;

        public Triangle(double h, double b)
        {
            this.hei = h;
            this.bas = b;
        }

        public double calArea()
        {
            return (bas * 0.5) * hei;
        }

        public void print()
        {
            Console.WriteLine($"Area of {this} is: {calArea()}");
            Console.ReadLine();
        }
    }
}
