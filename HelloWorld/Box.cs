using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// En esta clase se hace emplean conceptos de poo, tales como las funciones setter and getter
/// que forman parte del concepto "encapsulamiento", que se basa en no permitir el acceso a una 
/// variable de manera directa, si no en hacerlo por medio de métodos a los que si se puede accesar desde el exterior
/// </summary>

namespace helloWorld
{
    class Box
    {
        private int length = 3; //Esta ya no se puede cambiar desde afuera debido a su access modifier
        private int heigth;
        //public int width; //esto ya no es necesario debido a que se creó una porpiedad
        private int volume;

        //PROPERTIES
        public int Width { get; set; }
        //Eso equivale a esto
        public int Heigth
        {
            get
            {
                return this.heigth; //el valor que entrega la propiedad
                //Aqui es necesario usar una member variable para no crear un loop infinito
            }
            set
            {
                this.heigth = value; //el valor que toma la propiedad ( value es a lo que se asigna Heigth )
            }
        }

        public int Volume
        {
            get
            {
                return this.length * this.heigth * this.Width;
            }
        }

        public int FrontSurface
        {
            get{ return heigth * length; }           
        }


        public void SetLength(int length)
        {
            if(length<0)
            {
                throw new Exception("Length should be higher than 0"); //podemos crear nuestras propias excepciones
                //si pasa esto, la siguiente linea de codigo no se corre
            }
            this.length = length; //Con esto se puede modificar un member variable private
        }
        public int GetLength()
        {
            return this.length;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("The legth of the box is {0}, the heigth {1}, the " +
                "width is {2} so the volume is {3}", length, heigth, Width, volume = length * heigth * Width);
            Console.WriteLine("The front surface of the box is {0}", FrontSurface);
        }
    }
}
