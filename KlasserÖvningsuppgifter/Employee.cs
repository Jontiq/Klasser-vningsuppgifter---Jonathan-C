using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasserÖvningsuppgifter
{
    internal class Employee
    {
        //Properties
        private string _name;
        public string Name { get; set; }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    _age = 0;
                }
                else
                {
                    _age = value;
                }
            }
        }

        private decimal _salary;
        public decimal Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value < 0)
                {
                    _salary = 0;
                }
                else
                {
                    _salary = value;
                }
            }
        }

        //Konstruktör
        public Employee(string Name, int Age, decimal Salary)
        {
            this.Name = Name;
            this.Age = Age;
            this.Salary = Salary;
        }
        //Metoder
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary:C}");
        }
    }
}
