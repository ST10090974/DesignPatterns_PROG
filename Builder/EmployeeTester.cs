using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal class EmployeeTester
    {
        static void Main(string[] args)
        {
            EmployeeBuilder eb = new EmployeeBuilder()
                .WithStafNum("").WithName("John","Curtly")
                .WithSalary(12000).Build();

            Console.WriteLine(eb.ToString());
            Console.ReadLine(); 

        }
    }
}
