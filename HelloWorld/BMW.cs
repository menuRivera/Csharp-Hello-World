using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Derived class of Cars
/// </summary>
namespace helloWorld
{
    class BMW : Car 
    {
        private string brand = "BMW";
        public string Model { get; set; }
        //Default constructor
        public BMW()
        {

        }

        public BMW(int hp, string color, string model):base(hp, color) // :base(hp, color) means is inherited from the base class
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("Brand: {0}\nModel: {1}\nHP: {2}\nColor {3}", brand, Model, HP, Color);
        }
        public sealed override void Repair() //Is sealed, which means that it cannot be inheritanced again
        {
            Console.WriteLine("The BMW {0} was repaired",Model);
        }
    }
}
