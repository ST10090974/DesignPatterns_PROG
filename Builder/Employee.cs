using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal class Employee
    {
        public string StafNum { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee(string stafNum, string name, string surname, 
                        string email, string username, string password, 
                        int age, double salary)
        {
            StafNum = stafNum;
            Name = name;
            Surname = surname;
            Email = email;
            Username = username;
            Password = password;
            Age = age;
            Salary = salary;
        }

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public Employee(string stafNum)
        {
            StafNum = stafNum;
        }



    }
}
