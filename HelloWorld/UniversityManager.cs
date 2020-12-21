using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        //constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            //Adding some universities
            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            //Adding some students
            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityID = 1 });
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityID = 1 });
            students.Add(new Student { Id = 3, Name = "Jackson", Gender = "male", Age = 24, UniversityID = 2 });
            students.Add(new Student { Id = 4, Name = "Leyla", Gender = "female", Age = 19, UniversityID = 2 });
            students.Add(new Student { Id = 5, Name = "James", Gender = "trans-gender", Age = 25, UniversityID = 2 });
            students.Add(new Student { Id = 6, Name = "Linda", Gender = "female", Age = 22, UniversityID = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("\nMale students:");
            foreach (Student student in maleStudents)
                student.Print();
        }
        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("\nFemale students:");
            foreach (Student student in femaleStudents)
                student.Print();
        }
        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;
            Console.WriteLine("\nStudents sorted by age: ");
            foreach (Student student in sortedStudents)
                student.Print();
        }
        public void AllStudentsFromBeijingTech()
        {
            IEnumerable<Student> bjtStudents = from student in students
                                               join university in universities on student.UniversityID equals university.Id
                                               where university.Name == "Beijing Tech"
                                               select student;
            Console.WriteLine("\nStudents fromm Beijing Tech: ");
            foreach (Student student in bjtStudents)
                student.Print();
        }
        public void AllStudentsFromSelectedID(int ID)
        {
            IEnumerable<Student> sortedStudents = from student in students
                                               join university in universities on student.UniversityID equals university.Id
                                               where university.Id == ID
                                               select student;
            Console.WriteLine("Students from that university:");
            foreach (Student student in sortedStudents)
                student.Print();
        }
        public void StudentAndUniversityCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityID equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("\nNew collection:");
            foreach(var col in newCollection)
                Console.WriteLine("Student {0} from university {1}", col.StudentName, col.UniversityName);
        }
    }
}
