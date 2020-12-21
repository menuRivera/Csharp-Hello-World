using System;
using System.Collections.Generic;
using System.Text;

namespace helloWorld
{
    class Trainee:Employee
    {
        protected int WorkingHours { get; set; }
        protected string SchoolHouse { get; set; }

        public Trainee(string name, string firstName, int salary, int workingHours, string schoolHouse):base(name,firstName,salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHouse = schoolHouse;
        }
        public void Learn()
        {

        }

        public new void Work()
        {
            Console.WriteLine("{0} is working {1} hours per day", Name, WorkingHours);
        }
    }
}
