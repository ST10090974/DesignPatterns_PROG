using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory
{
    internal class Circle: IShapeCal
    {
        private double radius;

        public Circle(double r)
        {
            this.radius = r;
        }

        public double calArea()
        {
            return Math.PI * Math.Pow(radius,2);
        }

        public void print()
        {
            throw new NotImplementedException();
        }
    }
}
