using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        //Foreing Key
        public int UniversityID { get; set; }
        public void Print()
        {
            Console.WriteLine("Student {0} with ID {1}, Gender {2} and Age {3} from university with the ID {4}",
                Name, Id, Gender, Age, UniversityID);
        }
    }
}
