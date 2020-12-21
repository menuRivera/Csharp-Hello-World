using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using HelloWorld;
using System.Xml.Linq;
using System.Threading;

/// <summary>
/// Un programa en el que pretendo englobar los aspectos mas fundamentales de la programacion 
/// en c#, basandome, principalmente, en el curso "Complete C# masterclass" de la plataforma udemy.com
/// 
///  //Class names like ClientActivity
///  //Method names like CalculateValue
///  //method arguments like firstNumber
/// </summary>

namespace helloWorld
{

    class Program
    {
        const double PI = 3.14159265359; //esta madre jamas va a ser modificada, es una constante
        const string birthdate = "23.02.99";
        enum Day { Mo, Tu, We, Th, Fr, Sa, Su}; //these are like an array of constants
        enum Month { Jan=1, Feb, Mar, Apr, May, Jun, Jul=12, Aug, Sep, Oct, Nov, Dec}//You can set a different index index

        // ctrl+M+O to collapse all
        
        #region ::::::::::::::::::::::::::::::::::::::::::::::::: MAIN METHOD ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        static void Main(string[] args)
        {
            //local variables like itemCount

            //----------------LESSONS-----------------
            //DataTypeExample();
            //DataConvertionExample();
            //ConsoleClassExample();
            //MethodsExamples();
            //InputExamples();
            //IfStatementExamples();
            //SwitchStatementExamples();
            //LoopsExamples();
            //ClassesExamples();
            //ArraysAndListsExamples();
            //InheritanceExamples();
            //PolymorphismExamples();
            //TextFilesExamples();
            //StructsAndEnums();
            //MathClassExamples();
            //RandomClassExamples();
            //RegexExamples();
            //DateTimeExamples();
            //NullableExamples();
            //EventsAndDelegatesExamples();
            //LinqExamples();
            //ThreadsExamples();

            //----------------CHALLENGES-----------------
            //RegisterAndLoginIn();
            //AverageStudentsScores();
            //TicTacToeGame();
            //VideoPostPlayback();

            Console.ReadKey(true);
        }
        #endregion 
        
        #region ----------------LESSONS-----------------

        public static void DataTypeExample()
        {
            #region INT, DOUBLE y FLOAT

            int num1 = 13;
            int num2 = 3;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.337;
            double sumd = d1 + d2;

            float f1 = 1.4F; //A los flotantes se les debe agragar una F al final

            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            Console.WriteLine("The sum of " + d1 + " and " + d2 + " is " + sumd);

            #endregion
            
            #region STRINGS
            Console.WriteLine("\n");

            string myname = "Manuel compa";
            string message = "My name is " + myname;
            string capsMessage = message.ToUpper(); //Se usan los métodos de la clase "String" en la variable message
            Console.WriteLine(message + "\n(en mayúsculas) \n" + capsMessage);
            #endregion
           
            #region VARIABLES
            Console.WriteLine("\n");

            //Primitive variables
            int entero = 5;
            long largo = 43243254353543;
            short corto = 43;
            char caracter = 'M';
            float flotante = 32.42F;
            double doble = 34.44;
            bool boleano = true;
            string firstString = "I control text";
            string secondString = "54";
            int secondStringInt = int.Parse(secondString);

            Console.WriteLine(entero);
            Console.WriteLine(largo);
            Console.WriteLine(corto);
            Console.WriteLine(caracter);
            Console.WriteLine(flotante);
            Console.WriteLine(doble);
            Console.WriteLine(boleano);
            Console.WriteLine(entero);
            Console.WriteLine(firstString);
            Console.WriteLine(secondString);
            Console.WriteLine(secondStringInt);
            #endregion
        }
        public static void DataConvertionExample()
        {
            #region DATA CONVERTION (casting)
            Console.WriteLine("\n");

            //Conversion explícita
            double myDouble = 13.37;
            int myInteger;
            myInteger = (int)myDouble;

            Console.WriteLine("El valor double = " + myDouble);
            Console.WriteLine("El valor convertido a int = " + myInteger);

            //La conversion implícita se refiere a convertir el tamaño del tipo de dato; por ejemplo:
            int enteroGenerico = 321321321;
            long enetroGenericoMasGrande = enteroGenerico;
            float flotanteGenerico = 4.23F;
            double flotanteGenericoDouble = flotanteGenerico;

            //DataType Conversion
            string stringGenerica = "El valor del double convertido a string es de " + flotanteGenericoDouble.ToString();
            Console.WriteLine(stringGenerica);

            //String to integer
            string stringPedorra = "15"; //Tiene que ser un numero, de lo contrario salrá una excepción
            int stringPedorraInt = Int32.Parse(stringPedorra); //a entero
            string stringPedorrisima = "14.44";
            double stringPedorraDouble = Double.Parse(stringPedorrisima);
            Console.WriteLine(stringPedorraInt);
            Console.WriteLine(stringPedorraDouble);
            #endregion 
        }
        public static void ConsoleClassExample()
        {

            //*********************************************************************
            //CONSOLE CLASS
            Console.WriteLine("\n");

            Console.BackgroundColor = ConsoleColor.DarkBlue; //Ejemplo de propiedades de la clase Console
                                                             //Console.Clear(); 
                                                             //Este se puede usar para aplicar el color a toda la consola, de lo contrario, se aplicará a los elementos de aqui en delante
            Console.Write("Hola perros"); //Imprime en la misma linea //Ejemplo de métodos de la clase console
            Console.WriteLine("Hola perros"); //Imprime en una linea distinta de la consola
                                              //Console.Read(); //Retorna el valor ASCII del input
                                              //Console.ReadLine(); //Retorna el valor tal cual del input
            Console.BackgroundColor = ConsoleColor.Black;

        }
        public static void MethodsExamples()
        {
            #region STRING METHODS
            Console.WriteLine("\n");

            string testString = "El zapato de kiko";
            string testString2 = "    El zapato de kiko";
            string testStringSub = testString.Substring(4); //elimina 4 caracteres del string
            string testStringTrim = testString2.Trim(); //recorta los espacios en blanco al inicio y al final del string
            int index = testString.IndexOf("zapato", 0);//determina la posicion en la que aparece determinada palabra por primera vez a partir de cierto indice (0)

            Console.WriteLine(testString);
            Console.WriteLine(testStringSub);
            Console.WriteLine(testStringTrim);
            Console.WriteLine("La palabra zapato aparece en el caracter {0} del string testString", index);
            string[] values = { null, String.Empty, "ABCDE", new String(' ', 20), "  \t   ", new String('\u2000', 10) };
            foreach (string value in values)
            {
                Console.WriteLine(String.IsNullOrWhiteSpace(value));
            }

            string nombre = "Manuel ";
            string apellido = "Rivera";
            string nuevoNombre = String.Format("Jose {0}", nombre);
            string fullNameOld = string.Concat(nombre, apellido);
            string fullName = string.Concat(nuevoNombre, apellido);
            Console.WriteLine("Antes me llamaba {0}", fullNameOld);
            Console.WriteLine("Pero ahora me llamo " + fullName);
            Console.WriteLine("¿Esta vacío el nombre?\t" + String.IsNullOrWhiteSpace(nombre));
            #endregion

            #region METHODS
            Console.WriteLine("\n");

            WriteSomething(); //método descrito fuera del Main()
            WriteSomethingSpecific("I am an argument and am called from a method"); //ejemplo de parámetros
            int addMethod = Add(12, 4);
            Console.WriteLine("Ejemplo de un metodo con retorno de valores: " + addMethod); //ejemplo de return
            Console.WriteLine("Ejemplo de un metodo con retorno de valores: " + Add(4, 2));

            GreetFriend("Jorge");
            #endregion
        }
        public static void InputExamples()
        {
            //*********************************************************************
            //INPUT 
            Console.WriteLine("\n");

            Console.WriteLine("**ZONA DEL INPUT** \nEscribe algo y lo duplicaré");
            string input = Console.ReadLine();
            Console.WriteLine(input);

            SumaInput();

        }
        public static void IfStatementExamples()
        {
            #region IF STATEMENT
            Console.WriteLine("\n");

            Console.WriteLine("Cual es la temperatura?");
            string numTemp = Console.ReadLine();
            int temperature = int.Parse(numTemp);
            if(temperature < 10)
            {
                Console.WriteLine("Agarra un sueter, loco");
            }
            if(temperature == 10)
            {
                Console.WriteLine("Estamos a 10°C wey");
            }
            if(temperature > 10)
            {
                Console.WriteLine("Che caloron alv");
            }
            #endregion
            
            #region IF STATEMENT ENHANCED
            Console.WriteLine("\n");

            string stateOfMatter;
            stateOfMatter = temperature <= 0 ? "solido" : temperature >= 100 ? "gaseoso" : "liquido"; // ([condition] ? [trueCase] : [falseCase];)
                                                                                                      //La expresion a? b : c? : e; 
                                                                                                      //se lee de la forma:  a? b : (c? d : e);
            Console.WriteLine("El agua se encuentra en estado " + stateOfMatter);

            #endregion
            
            #region TRYPARSE METHOD
            Console.WriteLine("\n");

            Console.WriteLine("Test de TryParse, ingresa un valor");
            string numberAsString = Console.ReadLine();
            int parsedValueInt;
            double parsedValueDouble;
            bool successInt = int.TryParse(numberAsString, out parsedValueInt);
            bool successDouble = double.TryParse(numberAsString, out parsedValueDouble);

            if(successInt)
            {
                Console.WriteLine("Simon, si es numero entero esa madre");
            }
            else if (successDouble)
            {
                Console.WriteLine("Simon, es un numero de punto flotante");
            }
            else
            {
                Console.WriteLine("Esa madre no es un numero homs, lo siento");
            }
            #endregion
        }
        public static void SwitchStatementExamples()
        {
            int age = 15;

            switch(age)
            {
                case 15:
                    Console.WriteLine("Eres muy joven bro");
                    break;
                case 25:
                    Console.WriteLine("ta bien, si entras");
                    break;
                default:
                    Console.WriteLine("tons cuantos años tienes?");
                    break;
            }
        }
        public static void LoopsExamples()
        {
            #region FOR LOOP
            Console.WriteLine("\n");

            for (int i = 0; i < 50; i += 5)
            {
                if (i == 30)
                {
                    Console.WriteLine("At 30 we stop!");
                    break;
                }
                Console.WriteLine("Ejemplo de un break #" + i);
            }
            Console.WriteLine("\n");
            for (int j = 0; j < 50; j += 5)
            {
                if (j == 30)
                {
                    Console.WriteLine("we'll skip the 30");
                    continue;
                }
                Console.WriteLine("Ejemplo de un continue #" + j);
            }

            #endregion
            
            #region DO WHILE LOOP
            Console.WriteLine("\n");

            int counter = 0;
            do
            {
                Console.WriteLine("La cuenta va en:" + counter);
                counter++;

            } while (counter < 5);

            #endregion
            
            #region WHILE LOOP
            Console.WriteLine("\n");

            int peopleCounter = 0;
            string input = "";
            while (input.Equals(""))
            {
                Console.WriteLine("Please press enter, press anything else + enter to finish counting");
                peopleCounter++;
                input = Console.ReadLine();
                Console.WriteLine("Thanks, the count is:" + peopleCounter);
            }
            #endregion
        }
        public static void ClassesExamples()
        {      
            //Para entender estas lineas de código, es necesario abrir las clases correspondientes.
            #region Human class
      
            //Human class
            /*
            //create an object of my class
            Human manuel = new Human();
            manuel.firstName = "Manuel"; //access variable from outside and even change it
            manuel.lastName = "Rivera";
            manuel.IntroduceMyself(); //call methods of the class

            //otra manera de hacer lo anterior
            Human caris = new Human
            {
                firstName = "Cariño",
                lastName = "Palomares"
            };
            Console.WriteLine("\n");
            caris.IntroduceMyself();
            */

            //constructor (una mejor manera de hacer lo anterior)

            Human celia = new Human("Celia", "Rivera", "brown", 18);
            celia.IntroduceMyself();

            Human felipon = new Human("Felipon", "Ramirez", "green, of course", 21);
            felipon.IntroduceMyself();

            Human john = new Human("John", "Zapata", "blue");
            john.IntroduceMyself();

            Human milaneso = new Human("Milaneso", "Perez");
            milaneso.IntroduceMyself();

            Human wade = new Human("just Wade");
            wade.IntroduceMyself();

            Human empty = new Human();
            empty.IntroduceMyself();
            #endregion

            #region Box class
            Console.WriteLine("\n");

            Box caja = new Box();
            //caja.length = 3; //Esto no es posible debido al access modifier de la variable del miembro
            caja.SetLength(7); //se accede a la variable length por medio de un método
            Console.WriteLine("Length set to {0}", caja.GetLength()); //se accede al valor de caja.length por medio de un metodo
            caja.Heigth = 4; // esto no es una variable, es una propiedad con la que se modifica la variable heigth
            caja.Width = 5; //las propiedades se escriben con mayuscula al inicio para diferenciarla de las variables

            caja.DisplayInfo();
            #endregion

            #region Members class
            Console.WriteLine("\n");

            Members member1 = new Members();
            member1.Introducing(true);
            #endregion

        }
        public static void ArraysAndListsExamples()
        {
            #region arrays
            Console.WriteLine("array example");
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 9;
            grades[3] = 7;
            grades[4] = 11;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Grade at the index {0} is {1}", i, grades[i]);
            }

            Console.WriteLine("\n");
            int[] gradesOfMathStudentsA = { 12, 13, 6, 0, 12 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Grade at the index {0} is {1}", i, gradesOfMathStudentsA[i]);
            }

            Console.WriteLine("\nLength property example");
            int[] gradesOfMathStudentsB = new int[] { 20, 4, 5, 12, 11, 16, 18 };
            for (int i = 0; i < gradesOfMathStudentsB.Length; i++)
            {
                //se usa la propiedad Length para saber el tamaño de un array
                Console.WriteLine("Grade at the index {0} is {1}", i, gradesOfMathStudentsB[i]);
            }

            Console.WriteLine("length example " + gradesOfMathStudentsB.Length);

        
            //multidimensional array
            Console.WriteLine("'n");
            string[,] matrix; //declare 2d array
            string[,,] matrix3d; //declare 3d array
            int[,] num = new int[3, 5]; //declare an array w 3 rows and 5 columns

            int[,] array2D = new int[,] //initialize a 2d array
            {
                {1,2,3 }, //row0
                {4,5,6 }, //row1
                {7,8,9 }  //row2
            };
            Console.WriteLine("The value of [1,1] is {0}", array2D[1, 1]); //access a value in a 2d array

            string[,,] array3D = new string[,,]//initialize a 3d array
            {
                {
                    {"000", "001", "002"},
                    {"010", "011", "012"},
                    {"020", "021", "022"},
                },
                {
                    {"100", "101", "102"},
                    {"110", "111", "112"},
                    {"120", "121", "122"}
                },
                {
                    {"200", "201", "202"},
                    {"210", "211", "212"},
                    {"220", "221", "222"}
                }
            };
            Console.WriteLine("The value of [1,0,2] is {0}", array3D[1, 0, 2]); //access a value in a 2d array
            int array3DRank = array3D.Rank;
            Console.WriteLine("the array3D has {0} dimensions",array3DRank); //se usa rank para determinar cuantas dimensiones tiene un arreglo
            #endregion 

            #region foreachLoop
            //foreach loop    
            Console.WriteLine("\nforeach loop example");
            int counter = 0;
            foreach (int k in gradesOfMathStudentsB)
            {
                Console.WriteLine("Element {0} at gradesOfMathStudentsB is {1}", counter, k);
                counter++;
            }

            Console.WriteLine("\n");
            string[] friends = { "Benito", "Esteban", "Clotilde", "Carabino", "Rodris" };
            foreach (string k in friends)
            {
                Console.WriteLine("Hola {0}, como estas?", k);
            }
            #endregion

            #region jaggedArrays
            //jaggedArray
            Console.WriteLine("\n");

            int[][] jaggedArray = new int[3][]; //declare array
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 }; //add valueas
            jaggedArray[1] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[2] = new int[] { 12, 4 };

            int[][] jaggedArray2 = new int[][] //alternative way
            {
                new int[] { 2, 3, 5, 7, 11 },
                new int[] { 2, 3, 5 }
            };

            Console.WriteLine("Para accesar a los datos de un jagged array: {0}",jaggedArray2[0][2]); //access jaggedArray2 values

            for (int i = 0; i < jaggedArray2.Length; i++) //para accesar a los datos del jaggedArray 2
            {
                Console.WriteLine("Element {0}:",i);
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                    Console.WriteLine("{0}", jaggedArray2[i][j]);
            }

            string[][] friendsFams = new string[][]
            {
                new string[] {"Felipon", "brother John", "sister Danna"},
                new string[] {"Polo", "mother Nora", "father Oscar"},
                new string[] {"Ken Block", "aunt Elvira", "children Alex"}
            };
            Console.WriteLine("\n");
            for(int i=0; i<friendsFams.Length; i++)
            {
                Console.WriteLine("Hello, my name is {0}, and this is my {1}", friendsFams[i][0], friendsFams[i][1]);
                Console.WriteLine("Hello, my name is {0}, and this is my {1}", friendsFams[i][0], friendsFams[i][2]);
                Console.WriteLine("\n");
            }
            #endregion

            #region arrays as parameters
            //Get average method
            int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 16 };
            double averageResult = GetAverage(studentsGrades);
            Console.WriteLine("Grades:");
            foreach(int grade in studentsGrades)
            {
                Console.WriteLine("{0}", grade);
            }
            Console.WriteLine("The average is {0}", averageResult);

            //Happiness method
            Console.WriteLine("\n");
            int[] happiness = new int[] {3, 5, 6, 4, 1 };
            //This method increases by 2 the values in the happiness array
            Console.WriteLine("Actual value:");
            foreach(int k in happiness)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("New value:");
            HappinessMethod(happiness);
            foreach (int k in happiness)
            {
                Console.WriteLine(k);
            }

            #endregion

            #region arrayLists 
            Console.WriteLine("\n");
            //add the system.collections class in order to access this function
            ArrayList myArrayList = new ArrayList(); //indefined amount of objects
            ArrayList myArrayList2 = new ArrayList(100); //defined amount of objects

            myArrayList.Add(25); //add elements to the arraylist
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);

            myArrayList.Remove(13); //delete element with specific value from the arraylist (just one)
            myArrayList.RemoveAt(0); //delete the element with that specific index

            Console.WriteLine(myArrayList.Count);
            double sum = 0;
            foreach(object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if(obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine("the sum is {0}",sum);

            #endregion

            #region lists
            Console.WriteLine("\n");

            var numbers = new List<int>(); //list of type int without values
            var numbers2 = new List<int> { 1, 5, 35, 100 }; //list of the type int with values

            numbers.Add(7); //adds an integer with a value of 7 to our list
            numbers.Add(44);
            numbers.Remove(44); //removes an element with a value of 7 from our list
            int index = 0;
            numbers.Remove(index); //removes an element at a specific position (index)

            //Getting a value
            _ = numbers2[2]; //it'll be 35 (discard used)
            numbers2.Clear(); //This will clear the whole content of our list

            var people = new List<string> { "Jose", "Arturo", "Carlos", "Pepe" };

            foreach (string k in people) //foreach loop
                Console.WriteLine(k);

            #endregion

            #region Arrays vs Lists vs ArrayLists
            Console.WriteLine("\n");

            //array (inmutable, limited to one type)
            int[] array = new int[] { 99, 96, 87, 76 };

            //list
            List<int> list = new List<int> { 1, 2, 3, 4 };
            list.Add(0); //added at the end of the list
            list.Add(35);
            list.Add(3);
            Console.WriteLine("List:");
            Console.WriteLine("Before .Sort()");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            list.Sort(); //in order to sort the elements in this collection
            Console.WriteLine("After .Sort()");

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Does this list have a 4 in it? " + list.Contains(4));
            int indexOf4 = list.FindIndex(x => x == 4); //lambda expresion
                                                        //this means that a variable (x) will pass through the whole list and will return the index
                                                        //in where the x equals 4
            Console.WriteLine("Where? at position " + indexOf4);

            Console.WriteLine("ForEach method of lists");
            list.ForEach(i => Console.WriteLine(i)); //lambda expresion
                                                     //This will create a variable (i) that will pass through the whole list taking each one of their 
                                                     //values and it'll do whatever is after the => sign, in this case, cw

            //arraylist
            Console.WriteLine("\n");

            ArrayList arrayListExample = new System.Collections.ArrayList();
            arrayListExample.Add(1);
            arrayListExample.Add("Hola zapato");
            arrayListExample.Add(new Number { N="cuatro"}); //ejemplo de que literal se le pueden meter objetos

            foreach(object o in arrayListExample)
                Console.WriteLine(o);


            #endregion
        }
        public static void InheritanceExamples()
        {
            //Post class, nothing new
            Post post1 = new Post("Thanks for the birthday wishes", true, "Manuel Rivera");
            Console.WriteLine(post1.ToString());

            //ImagePost class, derived from Post
            ImagePost imagePost1 = new ImagePost("Check out my new shoes lmao", "Manuel Rivera", 
                "https://images.com/shoes", true);
            Console.WriteLine(imagePost1.ToString());

            //Challenge
            //VideoPostPlayback();


            //Employees class
            Console.WriteLine("\n");
            Employee employee1 = new Employee("Carlos Jose", "Carlos", 3000);
            Trainee trainee1 = new Trainee("Fernando Rubio", "Fernando", 5000, 7, "Universidad de Guadalajara");
            Boss boss1 = new Boss("John Cena", "John", 10000, "Ford Fiesta");

            boss1.Lead();
            trainee1.Work();


            //Interface
            Console.WriteLine("\n");
            Notification n1 = new Notification("Manuel Rivera", "Puto el que lo lea", "Today");
            n1.ShowNotification();
        }
        public static void PolymorphismExamples()
        {
            var cars = new List<Car>
            {
                new Audi(200,"Red", "R8"),
                new BMW (300, "White", "E30")
            };
            
            foreach(var car in cars)
            {
                car.ShowDetails(); //This one will take the base class method, due to the new keyword 
                car.Repair();  //This one will take the derived class method, due its overrided
                Console.WriteLine("\n");              
            }


            Console.WriteLine("Using the derived class method\n");
            foreach(var car in cars)
            {
                //Casting those in order to use the derived class method
                if (car is BMW)
                {
                    BMW carB = (BMW)car;
                    carB.ShowDetails();
                    carB.Repair();
                }
                else if (car is Audi)
                {
                    Audi carB = (Audi)car;
                    carB.ShowDetails();
                    carB.Repair();
                }
                Console.WriteLine("\n");
            }
        }
        public static void TextFilesExamples()
        {
            #region read textFile
            string text = System.IO.File.ReadAllText(@"E:\Users\Lenovo\Documents\Códigos\C#\helloWorld\assets\textFile.txt");
            Console.WriteLine(text);

            Console.WriteLine("\n");
            string[] lines = System.IO.File.ReadAllLines(@"E:\Users\Lenovo\Documents\Códigos\C#\helloWorld\assets\textFile.txt");
            int i = 0;
            foreach(string line in lines)
            {
                Console.WriteLine("[line {0}]{1}",i++,line);
            }
            #endregion

            #region write textFile
            //write all lines
            string[] linesToWrite = { "First line", "second line", "third line" };
            System.IO.File.WriteAllLines(@"E:\Users\Lenovo\Documents\Códigos\C#\helloWorld\assets\textFile1.txt", linesToWrite);

            //write all text
            /*
            Console.WriteLine("\nText Files creator:");
            Console.WriteLine("Gimme the text file name:");
            string fileName = Console.ReadLine();
            Console.WriteLine("Now enter the text for the file:");
            string input = Console.ReadLine();
            File.WriteAllText(@"E:\Users\Lenovo\Documents\Códigos\C#\helloWorld\assets\" + fileName + ".txt", input);
            */
            //Stram writer
            using(StreamWriter file = new StreamWriter(@"E:\Users\Lenovo\Documents\Códigos\C#\helloWorld\assets\streamWriterExample.txt"))
            {
                file.WriteLine("Hola cabrones que chingue a su madre el america");
            };

            #endregion
        }
        public static void StructsAndEnums()
        {
            #region structs
            Game game1;
            game1.name = "pokemon";
            game1.developer = "Manuel Rivera";
            game1.rating = 9.1;
            game1.relaseDate = "9/1/19";
            game1.Display();
            #endregion

            #region enums

            Console.WriteLine("\n");
            Day fr = Day.Fr; 
            Day su = Day.Su;
            Day a = Day.Fr;

            Console.WriteLine(fr==a);
            Console.WriteLine(su);
            Console.WriteLine((int)su);

            Console.WriteLine((int)Month.Feb);
            Console.WriteLine((int)Month.Aug);

            #endregion
        }
        public static void MathClassExamples()
        {
            Console.WriteLine("Ceiling 14.3 to: " + Math.Ceiling(14.3)); //Redondeando
            Console.WriteLine("Floor 14.3 to: " + Math.Floor(14.3));

            int num1 = 32;
            int num2 = 30;

            Console.WriteLine("Min: " + Math.Min(num1,num2));
            Console.WriteLine("Max: " + Math.Max(num1, num2));
            Console.WriteLine("3 to the power of 2 is: " + Math.Pow(3,2));
            Console.WriteLine("Sqrt of 25 is: " + Math.Sqrt(25));
            Console.WriteLine("Always positive -4: "+ Math.Abs(-4));
            Console.WriteLine("Cos of 1 is: "+ Math.Cos(1));
        }
        public static void RandomClassExamples()
        {
            Random dice = new Random();
            int numEyes;
            for(int i=0; i<10; i++)
            {
                numEyes = dice.Next(1,7); //1 to 6, excluding the upper bound
                Console.WriteLine(numEyes);
            }


            Console.WriteLine("\n");
            Random rand1 = new Random();
            int g=rand1.Next(1, 4);
            if(g == 1)
                Console.WriteLine("yes");
            else if(g == 2)
                Console.WriteLine("maybe");
            else if (g==3)
                Console.WriteLine("no");
        }
        public static void RegexExamples()
        {            
            string pattern = @"\d";
            Regex regex = new Regex(pattern);

            string text = "Hi there, my number is 1233432";
            MatchCollection match = regex.Matches(text);
            Console.WriteLine("{0} hits found in: \n '{1}'",match.Count, text);
            Console.WriteLine("\n");
            foreach(Match hit in match)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} found at {1}",group[0].Value,group[0].Index);
            }
        }
        public static void DateTimeExamples()
        {
            DateTime dateTime = new DateTime(2018, 5, 31);
            Console.WriteLine(dateTime);

            //write today on screen
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomorrow will be {0} ",tomorrow);
            Console.WriteLine("Today is {0}",DateTime.Today.DayOfWeek);

            DateTime now = DateTime.Now;
            Console.WriteLine("Minute: {0}",now.Minute);
            Console.WriteLine("Actual time\n{0} hours, {1} minutes and {2} seconds",now.Hour, now.Minute, now.Second);

            Console.WriteLine(MyBirthdayDay(2001).DayOfWeek);

            Console.WriteLine("Enter a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("Days passed since: {0}",daysPassed);
            }
            else
                Console.WriteLine("Wrong input");
        }
        public static void NullableExamples()
        {
            int? num1 = null;
            int num2 = 3; //This one cannot be null

            double? num3 = new Double?();
            double? num4 = 3.4324;

            bool? boolval = new bool?();
            Console.WriteLine("->{0}\n->{1}\n->{2}\n->{3}\n->{4}",num1, num2, num3, num4, boolval);

            //The null coalescing operator ?? and ??=
            //this ones is for convertrng a nullable to a non-nullable
            double? num6 = 13.1;
            double? num7 = null;
            double num8;
            //returns the value of its left hand operand if it is not null, 
            //otherwise, it evaluates the right hand operand and returns its result.

            num8 = num6 ?? 8.53; //num6 is not null, thus num8 will take the value of num6
            Console.WriteLine("The value of num8 is {0}",num8);
            num8 = num7 ?? 8.22; //num7 is null, so num 8 will take the right hand operand (8.22)
            Console.WriteLine("The value of num8 is {0}", num8);

            num7 ??= 1.3; //checks if num7 is null, if it is, 1.3 will be assigned to num7
            Console.WriteLine(num7);
        }
        public static void EventsAndDelegatesExamples()
        {
            #region Delegate
            PerformCalculation getSum = Addition;
            getSum(5.0, 5.0);

            PerformCalculation getDivision = Division;
            getDivision(5, 5);

            Console.WriteLine("\nMulticalc delegate:");
            PerformCalculation multiCalc = getSum + getDivision;
            multiCalc(3.5, 5.5);
            multiCalc += Substraction;
            multiCalc(4, 4);
            #endregion

            #region Anonymous Methods
            Console.WriteLine("\n");
            
            GetTextDelegate getTextDelegate = delegate(string name)
            {
                return "Hello " + name;
            };

            Console.WriteLine(getTextDelegate("Manuel"));


            Display(getTextDelegate);//passing a delegate as an argument
            #endregion

            #region Lambda expression
            Console.WriteLine("\n");

            //lambda expression
            GetTextDelegate getHelloText = (string name) => { return "Hello " + name; };
            Console.WriteLine(getHelloText("Gary"));

            //statement lambda
            GetTextDelegate getGoodbyeText = (string name) =>
            {
                Console.WriteLine("I'm inside of an statement lambda");
                return "Goodbye " + name;
            };            
            Console.WriteLine(getGoodbyeText("Paquiao"));

            //short lambda statement
            GetTextDelegate getWelcomeText = name => "Welcome " + name;
            Console.WriteLine(getWelcomeText("Fujifilmino"));

            PerformCalculation performSum = (a, b) => a + b;
            Console.WriteLine("The sum is " + performSum(3.3,1.9));

            PerformCalculation performProduct = (a, b) => a * b;
            Console.WriteLine("The product is " + performProduct(5,4));
            #endregion

            #region events
            Console.WriteLine("\n**Events**");
            //enables communication between objects
            //classes involved: DownloadHelper, File, UnpackService, NotificationService

            /*This example is about a download currently active, once 
             * is finished, the publisher will bring a message to the receiver
             * and start unpacking. Each event triggered will show a notification
             */

            //Create objects
            var file = new File() { Title = "La_Morsa.mp4" };
            var downloadHelper = new DownloadService(); //publisher
            var unpackService = new UnpackService(); //receiver (also publisher at some point)
            var notificationService = new NotificationService(); //receiver

            //setting up the "receivers"
            // [object].[eventHandlerDelegate] += [objectReceiver].[methodToTrigger]
            downloadHelper.FileDownloaded += notificationService.OnFileDownloaded; // once is downloaded, notify
            downloadHelper.FileDownloaded += unpackService.OnFileDownloaded; //once is downloaded, start unpacking

            unpackService.FileUnpacked += notificationService.OnFileUnpacked; //once is unpacking, notify

            //download the file and start the process
            downloadHelper.Download(file);
            
            #endregion
        }
        public static void LinqExamples()
        {
            #region Basic example
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Odd numbers: ");
            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;
            Console.WriteLine(oddNumbers);
            foreach (int i in oddNumbers)
                Console.WriteLine(i);

            Console.WriteLine("\n");
            int[] someInts = { 30, 12, 4, 3, 12 };
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();
            foreach(int i in reversedInts)
                Console.WriteLine(i);

            //Another way to do that:
            Console.WriteLine("\n");
            IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;
            foreach (int i in reversedSortedInts)
                Console.WriteLine(i);
            #endregion

            #region University Manager example
            Console.WriteLine("\nUNIVERSITY MANAGER\n");

            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            um.FemaleStudents();
            um.SortStudentsByAge();
            um.AllStudentsFromBeijingTech();
            /*Challenge
            Console.WriteLine("Select a university:\n1=Yale\n2=Beijing Tech\n");
            string input = Console.ReadLine();
            try
            {
                int inputAsInt = Convert.ToInt32(input);
                um.AllStudentsFromSelectedID(inputAsInt);
            }
            catch (Exception)
            {

                throw;
            }
            */
            um.StudentAndUniversityCollection();

            #endregion

            #region Linq with XML
            Console.WriteLine("\nXML\n");

            string studentsXML =
                @"<Students>
                    <Student>
                        <Name>Toni</Name>
                        <Age>21</Age>
                        <University>Yale</University>
                        <Semester>6</Semester>
                    </Student>
                    <Student>
                        <Name>Carla</Name>
                        <Age>17</Age>
                        <University>Yale</University>
                        <Semester>4</Semester>
                    </Student>
                    <Student>
                        <Name>Leyla</Name>
                        <Age>19</Age>
                        <University>Beijing Tech</University>
                        <Semester>3</Semester>
                    </Student>
                    <Student>
                        <Name>Frank</Name>
                        <Age>25</Age>
                        <University>Yale</University>
                        <Semester>7</Semester>
                    </Student>
                </Students>";
            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Semester = student.Element("Semester").Value
                           };

            foreach (var student in students)
                Console.WriteLine("Student {0} with age {1} from {2}. Semester {3}", student.Name, student.Age, student.University, student.Semester);

            //sorted by age
            Console.WriteLine("\nSORTED BY AGE");
            var sortedByAge = from student in students orderby student.Age select student;

            foreach(var student in sortedByAge)
                Console.WriteLine("{0}, Age {1}",student.Name, student.Age);
            #endregion
        }
        public static void ThreadsExamples()
        {

            #region Basics
            /*
            Console.WriteLine("HelloWorld1");
            Thread.Sleep(1000); //suspends the whole main thread for 1 second
            Console.WriteLine("HelloWorld2");
            Thread.Sleep(1000);
            Console.WriteLine("HelloWorld3");

            //these statements run moreless at the same time
            new Thread(() =>
            {                
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");
            }).Start();
            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");
            }).Start();
            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 3");
            }).Start();
            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");
            }).Start();
            */
            #endregion

            #region Start, end and completion
            /*
            Console.WriteLine("\nSTART, END AND COMPLETION\n");
            var taskCompletionSource = new TaskCompletionSource<bool>();
            var thread = new Thread(() =>
            {
                Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} (started)");

                Thread.Sleep(1000);
                taskCompletionSource.TrySetResult(true);

                Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} (ended)");
            });            
            thread.Start();
            var test = taskCompletionSource.Task.Result;
            Console.WriteLine("task was done {0}",test);
            */
            #endregion

            #region Thread pools
            /*
            Console.WriteLine("\nTHREAD POOLS\n");

            Enumerable.Range(0, 100).ToList().ForEach(f =>
            {
                //The threadpool creates only a certain amount of threads
                ThreadPool.QueueUserWorkItem((o) =>
                {
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} (started)");

                    Thread.Sleep(1000);

                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} (ended)");
                });
            });
            */
            #endregion

            #region Join And IsAlive
            Console.WriteLine("\nJOIN, ISALIVE\n");

            Console.WriteLine("Main thread started");
            Thread thread1 = new Thread(Thread1Function);
            Thread thread2 = new Thread(Thread2Function);
            thread1.Start();
            thread2.Start();

            //joins the main thread, thus the main thread will have to wait till thread1 is done
            if (thread1.Join(1000)) //gives 1 second to thread1 to get his stuff done, after 1 second, the main thread will move on
                Console.WriteLine("Thread1Function done");
            else
                Console.WriteLine("Thread1Function wasn't done within 1 second");
            thread2.Join();
            Console.WriteLine("thread1 function done");

            //IsAlive property
            if (thread1.IsAlive)
                Console.WriteLine("thread1 is still doing stuff");
            else
                Console.WriteLine("thread1 completed");



            Console.WriteLine("Main thread ended");

            #endregion
        }


        #endregion

        #region ----------------CHALLENGES-----------------

        public static void RegisterAndLoginIn()
        {
            //programa que permite un login dentro del mismo runtime
            string username;
            string password;
            Register();
            Login();

            void Register()
            {
                Console.WriteLine("Enter your username");
                username = Console.ReadLine();
                Console.WriteLine("Enter your password");
                password = Console.ReadLine();
                Console.WriteLine("Registration completed");
            }
            void Login()
            {
                Console.WriteLine("Enter your username");
                if (username == Console.ReadLine())
                {
                    Console.WriteLine("Enter your password");
                    if (password == Console.ReadLine())
                    {
                        Console.WriteLine("Login successful");
                    }
                    else
                    {
                        Console.WriteLine("login failed, wrong password. Restart program");
                    }
                }
                else
                {
                    Console.WriteLine("login failed, wrong user. Restart program");
                }
            }
        }
        public static void AverageStudentsScores()
        {
            string input;
            double averageScore=0;
            
            Console.WriteLine("Average students scores program\n::::::::::::::::::::::::::::::\n");
            for (int i=0;i>=0;i++)
            {
                Console.WriteLine("Enter a score or -1 to end the program:");
                input = Console.ReadLine();

                if(!(double.TryParse(input, out double currentScore)))
                {
                    Console.WriteLine("That was not a number, genius");
                    i--;
                }
                else if(currentScore == -1)
                {
                    averageScore = averageScore / i;
                    Console.WriteLine("The average score of the whole class is {0}", averageScore);
                    break;
                }
                else if (currentScore < 20 && currentScore >= 0)
                {
                    averageScore += currentScore;
                }
                else
                {
                    Console.WriteLine("You must enter a number between 0 and 20, please try again");
                    i--;
                }
                                                        
            }
            
        }
        public static void TicTacToeGame()
        {
            string[] game = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int turn = 1;
            string choice;
            int a = 1;
            int winner=0;
            int player1=0;
            int player2=0; 
            #region gamezone
            while (a==1)
            {
                if (winner==0)
                {
                    //round secuence
                    DisplayBoard();
                    Turn();
                    Verify();
                    Console.Clear();
                } 
                else
                {
                    DisplayBoard();
                    if (winner == 1)
                    {
                        Console.WriteLine("***Player 1 wins***");
                        player1++;
                    }
                    else if (winner == 2)
                    {
                        Console.WriteLine("***Player 2 wins***");
                        player2++;
                    }
                    else
                        Console.WriteLine("****Draw****");

                    Console.WriteLine("\nDo you want to play again?\n1=yes\n0=no");
                    a = int.Parse(Console.ReadLine());

                    if (a == 1)
                    {
                        Reset();
                        Console.Clear();
                    }
                    else
                        FinalScore();
                }

            }
            #endregion

            void DisplayBoard()
            {
                Console.WriteLine("| {0} | {1} | {2} |\n| {3} | {4} | {5} |\n| {6} | {7} | {8} |\nP1 wins: {9}    P2 wins: {10}",
                    game[0], game[1], game[2], game[3], game[4], game[5], game[6], game[7], game[8], player1, player2);
            }
            void Turn()
            {
                //Player 1
                if(turn == 1) 
                {
                    int success = 0;
                    while (success == 0)
                    {
                        Console.WriteLine("Player 1, choose!");
                        choice = Console.ReadLine();
                        for (int i = 0; i < game.Length; i++)
                        {
                            if (choice.Equals(game[i]) && choice!="X")
                            {
                                game[i] = "O";
                                success = 1;
                                break;
                            }
                        }
                        if(success==0)
                            Console.WriteLine("Please, select one of the numbers in the board");
                    }
                }
                //Player 2
                else 
                {
                    int success = 0;
                    while (success == 0)
                    {
                        Console.WriteLine("Player 2, choose!");
                        choice = Console.ReadLine();
                        for (int i = 0; i < game.Length; i++)
                        {
                            if (choice.Equals(game[i]) && choice != "O")
                            {
                                game[i] = "X";
                                success = 1;
                                break;
                            }
                        }
                        if (success == 0)
                            Console.WriteLine("Please, select one of the numbers in the board");
                    }
                }
                turn = -turn;
            }
            void Verify()
            {
                if (game[0] == game[1] && game[1] == game[2])
                {
                    if (game[0].Equals("O"))
                        winner = 1;
                    else
                        winner = 2;
                }
                else if (game[3] == game[4] && game[4] == game[5])
                {
                    if (game[3].Equals("O"))
                        winner = 1;
                    else
                        winner = 2;
                }
                else if (game[6] == game[7] && game[7] == game[8])
                {
                    if (game[6].Equals("O"))
                        winner = 1;
                    else
                        winner = 2;
                }
                else if (game[0] == game[3] && game[3] == game[6])
                {
                    if (game[0].Equals("O"))
                        winner = 1;
                    else
                        winner = 2;
                }
                else if (game[1] == game[4] && game[4] == game[7])
                {
                    if (game[1].Equals("O"))
                        winner = 1;
                    else
                        winner = 2;
                }
                else if (game[2] == game[5] && game[5] == game[8])
                {
                    if (game[2].Equals("O"))
                        winner = 1;
                    else
                        winner = 2;
                }
                else if (game[0] == game[4] && game[4] == game[8])
                {
                    if (game[0].Equals("O"))
                        winner = 1;
                    else
                        winner = 2;
                }
                else if (game[2] == game[4] && game[4] == game[6])
                {
                    if (game[2].Equals("O"))
                        winner = 1;
                    else
                        winner = 2;
                }
                else if (game[0] != "1" && game[1] != "2" && game[2] != "3" && game[3] != "4" && game[4] != "5" && game[5] != "6" && game[6] != "7" && game[7] != "8" && game[8] != "9")
                    winner = 3;
            }
            void Reset()
            {
                winner = 0;
                turn = 1;
                //reseting the board
                for(int i=0;i<game.Length;i++)
                {
                    game[i] = (i+1).ToString();
                }
            }
            void FinalScore()
            {
                Console.Clear();
                if(player1>player2)
                    Console.WriteLine("Player 1 won the match!\nResults:\nPlayer 1 = {0} wins\tPlayer 2 = {1} wins",player1,player2);
                
                else if(player1<player2)
                    Console.WriteLine("Player 2 won the match!\nResults:\nPlayer 1 = {0} wins\tPlayer 2 = {1} wins", player1, player2);
                else
                    Console.WriteLine("DRAW!\nResults:\nPlayer 1 = {0} wins\tPlayer 2 = {1} wins", player1, player2);

            }
        }
        public static void VideoPostPlayback()
        {
            VideoPost videoPost1 = new VideoPost("A video sample", "Manuel Rivera", "https://video.com", 10, true);
            Console.WriteLine("Which playback method would you like to use?\nDenis=0\nManuel=1\n");
            int r = int.Parse(Console.ReadLine());
            if(r==0)
            {
                Console.WriteLine(videoPost1.ToString());                  
                videoPost1.Play();
                Console.ReadKey(true);
                videoPost1.Stop();
            }
            else if(r==1)
            {
                Console.WriteLine(videoPost1.ToString());
                videoPost1.StartMine();
                Console.ReadKey(true);
                videoPost1.StopMine();
            }
            else
                Console.WriteLine("Error, that option wasnt displayed");
        }

        #endregion

        #region ----------------EXTRAS-----------------

        //Forma de un método
        //access modifier, (static), return type, method name(Param1, Param2){}
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }
        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static void GreetFriend(string name)
        {
            Console.WriteLine("Hello {0}, my friend!", name);
        }
        //try, catch and finally example
        public static void SumaInput()
        {
            Console.WriteLine("\nMINI PROGRAMA SUMADOR");
            Console.WriteLine("\nIngresa un numero:\t");
            string numero1 = Console.ReadLine();
            Console.WriteLine("\nIngresa otro numero:\t");
            string numero2 = Console.ReadLine();
           try
            {
                int sumaGenerica = int.Parse(numero1) + int.Parse(numero2);  //se prueba esta linea de código, si el programa "crashea", se salta al catch 
                Console.WriteLine("\nEl resultado de la suma es\n" + sumaGenerica);
            }
            catch (FormatException)
            {
                Console.WriteLine("Dije numero compa");  //Se corre este codigo en caso de que la excecion sea del tipo format
                
            }
            catch (OverflowException)
            {
                Console.WriteLine("El numero es demasiado grande o demasiado pequeño");  //Se corre este codigo en caso de que la excecion sea del tipo overflow   
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Argument null excetion, el valor esta vacío (null)");
            }
            finally
            {
                Console.WriteLine("\nGracias por participar");
            }

            //double tap to insert the try snippet
                        
        }
        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i=0;i<size;i++)
            {
                sum += gradesArray[i];
            }

            average = (double)sum / size;
            return average;
        }
        static void HappinessMethod(int[] array)
        {
            for (int i=0;i<array.Length;i++)
            {
                array[i] += 2;
            }            
        }
        struct Game
        {
            public string name;
            public string developer;
            public double rating;
            public string relaseDate;

            public void Display()
            {
                Console.WriteLine(name +"\n"+ developer + "\n" + rating + "\n" + relaseDate);
            }
        }
        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
        static DateTime MyBirthdayDay(int year)
        {
            DateTime bday = new DateTime(year, 02, 23);
            return bday;

        }

        public delegate double PerformCalculation(double x, double y);
        public static double Addition(double a, double b)
        {
            Console.WriteLine($"The sum is {a + b}");
            return a + b;
        }
        public static double Division(double a, double b)
        {
            Console.WriteLine($"The division is {a / b}");
            return a / b;
        }
        public static double Substraction(double a, double b)
        {
            Console.WriteLine($"The substraction is {a - b}");
            return a - b;
        }
        public delegate string GetTextDelegate(string name);
        public static void Display(GetTextDelegate getTextDelegate)
        {
            Console.WriteLine(getTextDelegate("Fuckencio"));
        }
        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function started");
            Thread.Sleep(3000);
            Console.WriteLine("Thread1Function coming back to caller");
        }
        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function started");
            Thread.Sleep(1000);
            Console.WriteLine("Thread2Function coming back to caller");
        }

        #endregion

        #region ----------------DEBUGGING NOTES-----------------

        /* 
         * Autos: autos show us the variables that are which are arond the current breakpoint
         * Watch: to watch specific variables around the program
         * Locals: show us the variables that are available in the local context (scope)
         * Call stack: tell us from where was called a certain function or method
         */

        #endregion
    }
}