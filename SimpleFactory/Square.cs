using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory
{
    internal class Square: IShapeCal
    {
        private double side;

        public Square(double s)
        {
            this.side = s;
        }

        public double calArea()
        {
            return side*side;
        }

        public void print()
        {
            Console.WriteLine($"Area of {this} is: {calArea()}");
            Console.ReadLine();
        }
    }
}
