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
            throw new NotImplementedException();
        }

        public void print()
        {
            throw new NotImplementedException();
        }
    }
}
