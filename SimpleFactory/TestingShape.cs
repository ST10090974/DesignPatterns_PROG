using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SimpleFactory
{
    internal class TestingShape
    {
        static void Main(string[] args)
        {
            string op;
            Console.Write("Enter 'R-Rectangle', 'S-Square', or 'C-Circle'");
            op = Console.ReadLine();    
            FactoryShape fs = new FactoryShape();
            IShapeCal sha = fs.GetShape(op.ToUpper());
            sha.print();

        }
    }
}
