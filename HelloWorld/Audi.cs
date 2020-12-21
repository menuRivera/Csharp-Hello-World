using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Derived class of Cars
/// </summary>
namespace helloWorld
{
    class Audi : Car
    {
        private string brand = "Audi";
        public string Model { get; set; }

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("Brand: {0}\nModel: {1}\nHP: {2}\nColor {3}", brand, Model, HP, Color);
        }
        public override void Repair()
        {
            Console.WriteLine("The Audi {0} was repaired", Model);
        }
    }
}

