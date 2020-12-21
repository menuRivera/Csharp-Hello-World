using System;
using System.Collections.Generic;
using System.Text;

namespace helloWorld
{
    class Employee
    {
        //properties
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        //constructors
        public Employee() 
        {
            Name = "Benito John";
            FirstName = "Benito";
            Salary = 10000;
        }
        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        //methods
        public void Work()
        {
            Console.WriteLine("{0} is working",Name);
        }
        public void Pause()
        {
            Console.WriteLine("{0} is having a break",Name);
        }

    }
}
