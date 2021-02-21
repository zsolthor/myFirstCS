using System;

namespace fromLecture57
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Lecture 57: Passing Objects to Methods
            // Lecture 58: Arrays of Objects
            // Lecture 59: StaticKeyword 

            ////////// Lecture 57: Passing Objects to Methods //////////
            Person p1 = new Person("Jesse", 20);
            Console.WriteLine("BEFORE {0}, {1}", p1.Name, p1.Age);

            ChangePerson(p1);
            Console.WriteLine("AFTER {0}, {1}", p1.Name, p1.Age);

            // another change
            Person p2 = p1;
            p2.Name = "Test";
            Console.WriteLine("AFTER alter 2: {0}, {1}", p1.Name, p1.Age);

            //when You pass a referenece type to a function
            //it gets passed by reference
            //and any changes you make to affect the original class
            //any time you pass the reference of a class to something now those two pieces of data point at the same place.
            //any changes you make ti either variable will affect the same.

            ////////// Lecture 58: Arrays of Objects //////////

            int[] myArray = new int[2]; //an integer array the array itself is a reference type, we use the new keyword
            myArray[0] = 5;  // actual elements are integeres which are structures and are not reference types
            myArray[1] = 5;  //we dont use here the new keyword.

            // we had class called person --> a private name and a private age constructor and two properties for accessing the data.
            // make an array of people that will have 2 persons in the array

            Person[] peopleArray = new Person[2];
            peopleArray[0] = new Person("bob", 4);
            peopleArray[1] = new Person("test", 6);  // every person has its own memory location with the call new.

            for (int i = 0; i < peopleArray.Length; i++)
            {
                Console.WriteLine("{0} from Array and his/her age {1}", peopleArray[i].Name, peopleArray[i].Age);
               
            }
            Console.WriteLine("In the Array of people we had {0} person", peopleArray.Length);


            ////////// Lecture 59: StaticKeyword //////////
            ///

            Person p10 = new Person("Superman", 42);
            Person p11 = new Person("Batman", 41);
            //p10.-után nem látszik Count. We acces it through the actual class itself.
            Console.WriteLine("Person.Count számláló értéke jelenleg: {0}",Person.Count);  //Console is blue - it is a class. WriteLine is a function. we ara accessing the WriteLine function directly to the class. 
                                                                                           //jobb egér peek definition --> látszik static (public static void)    
            Test();

            // from quiz: Instance and object mean the same thing. True
            // A constructor is a method. True
            // Properties are a C# specific implementation of get and set methods. True
            // Auto implemented properties automatically create the private variable for you. True
            // When you pass an object to a method, the object is passed by reference True
            // A static variable is a variable that can be used with instances. False
            // A static method is a method that CAN'T be used with instances. True
            // Console.WriteLine() is an example of a static function. True
            // A class constructor should be private. False

        }

        public static void ChangePerson(Person p1)
        {
            p1.Name = "Jeff";
            p1.Age = 50;
        }

        public static void Test()   // static nélkül nem hívható meg felül.
        {                           //Main can't see test because test is instance
            Console.WriteLine("test");  //if you have a static function you can only call other static function unless you create a new instance inside of there like we do in here.
        }
    }
}