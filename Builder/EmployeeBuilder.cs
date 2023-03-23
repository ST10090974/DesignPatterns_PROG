using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal class EmployeeBuilder
    {
        public string StafNum { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public EmployeeBuilder WithStafNum(string stafNum)
        {
            this.StafNum = stafNum;
            return this;
        }

        public EmployeeBuilder WithName(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            return this;
        }

        public EmployeeBuilder Withcreditial(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            return this;
        }

        public EmployeeBuilder WithAge(int age) 
        { 
            this.Age = age; return this; 
        }

        public EmployeeBuilder WithEmail(string email) 
        { 
            this.Email = email; return this; 
        }

        public EmployeeBuilder WithSalary(double salary)
        {
            this.Salary = salary;
            return this;
        }


        private bool CheckBuild()
        {
            return StafNum.Length <= 0;
        }
        public EmployeeBuilder Build()
        {
            if (CheckBuild())
            {
                throw new Exception("Staff number needed");
            }

            return this;
        }

        public override string ToString()
        {
            return $"Staff No: {StafNum}\n" +
                $"Name: {Name} {Surname}\n" +
                $"Email: {Email}\n" +
                $"Age: {Age}\n" +
                $"Salary: {Salary}\n";
        }
    }
}
