using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
/// <summary>
/// Base Class
/// </summary>

namespace helloWorld
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        //Has a 
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }
        public void GetCarInfo()
        {
            Console.WriteLine("Owner: {0}\nCar ID: {1}", carIDInfo.Owner, carIDInfo.IDNum);
        }


        //Default
        public Car()
        {
            HP = 100;
            Color = "White";
        }
        //Specific
        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        //Methods
        public void ShowDetails()
        {
            Console.WriteLine("HP: {0}\nColor {1}",HP,Color);
        }
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }
    }
}
