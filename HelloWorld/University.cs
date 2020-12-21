using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("University {0} with ID {1}", Name, Id);
        }
    }
}
