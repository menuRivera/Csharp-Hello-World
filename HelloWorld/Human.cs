using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// En esta clase se explican conceptos basicos de las clases, como las variables de miembros, los 
/// metodos de las clases, los modificadores de acceso y los constructores.
/// </summary>

namespace helloWorld
{
    //blueprint of a datatype
    class Human
    {
        //member variable
        private string firstName; //public in order to access this variable from the outside 
        private string lastName;  //las variables del objeto se pueden hacer privadas cuando se usa un constructor, pues 
                                  //los datos se asignan por medio del constructor, que es publico
        private string eyeColor;
        private int age;

        //Constructors
        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }
        public Human(string firstName)
        {
            this.firstName = firstName;
        }
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }    
        public Human(string firstName, string lastNameConstructor, string eyeColor, int age)
        {
            this.firstName = firstName; //this.firstName se refiere a la variable del objeto
                                        //mientras que firsName se refiere a la del constructor
            lastName = lastNameConstructor;//Tambien se puede hacer de esta manera
            this.eyeColor = eyeColor;
            this.age = age;
        }        

        //member method
        public void IntroduceMyself()
        {
            if (age != 0 && eyeColor != null && lastName != null && firstName != null)
                Console.WriteLine("Hello, my name is {0} {1}, I'm {2} years old. My eye color is {3}", firstName, lastName, age, eyeColor);
            else if (age == 0 && eyeColor != null && lastName != null && firstName != null)
                Console.WriteLine("Hello, my name is {0} {1}, My eye color is {2}", firstName, lastName, eyeColor);
            else if (age == 0 && eyeColor == null && lastName != null && firstName != null)
                Console.WriteLine("Hello, my name is {0} {1}", firstName, lastName);
            else if (age == 0 && eyeColor == null && lastName == null && firstName != null)
                Console.WriteLine("Hello, my name is {0}", firstName);
            else
                Console.WriteLine("I can´t introduce myselft cause i dont have atributes");
        }
       
    }
}
