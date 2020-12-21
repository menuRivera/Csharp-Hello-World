using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace helloWorld
{
    class Members
    {
        //member private field
        private string memberName;
        private string jobTitle;
        private int salary;

        //member public field
        public int age;

        //member property (exposes jobTitle safely (properties start with a capital letter))
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        //member methods
        public void Introducing(bool isFriend)
        {
            if(isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm  {2} years old",memberName, jobTitle, age);
            }
        }
        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}",salary);
        }

        //member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "developer";
            Console.WriteLine("Object created");
            Debug.WriteLine("***Aqui wey***");
        }

        //member finalizer or destrutor
        ~Members()
        {
            //clanup statements
            Console.WriteLine("Destruction of members objects");
            Debug.Write("Destruction of members objects\n");
        }
    }
}