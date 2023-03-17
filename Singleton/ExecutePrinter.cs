using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    internal class ExecutePrinter
    {
        static void Main(string[] args)
        {
            Printer prin1 = Printer.GetInstance();
            Printer prin2 = Printer.GetInstance();

            Console.WriteLine(prin1.GetHashCode());
            Console.WriteLine(prin2.GetHashCode());

            Console.ReadLine();
        }
    }
}
