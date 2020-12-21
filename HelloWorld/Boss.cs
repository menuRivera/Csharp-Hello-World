using System;
using System.Collections.Generic;
using System.Text;

namespace helloWorld
{
    class Boss:Employee
    {
        public string CompanyCar { get; set; }
        public Boss(string name, string firstName, int salary, string companyCar):base(name,firstName,salary) //this takes the declaration made in the base class (Employees)
        {
            this.CompanyCar = companyCar;
        }
        public void Lead()
        {
            Console.WriteLine("The boss {0} is leading",Name);
        }

    }
}
