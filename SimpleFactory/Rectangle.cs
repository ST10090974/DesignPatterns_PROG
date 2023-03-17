using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory
{
    internal class Rectangle: IShapeCal
    {
        private double len, wid;

        public Rectangle(double l, double w)
        {
            this.len = l;
            this.wid = w;
        }

        public double calArea()
        {
            return len * wid;
        }

        public void print()
        {
            Console.WriteLine($"Area of {this} is: {calArea()}");
            Console.ReadLine();
        }
    }
}
