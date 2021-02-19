using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fromLecture51
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Lecture 52: Creating a Class
            // Lecture 53: Constructors
            // Lecture 54: Get and Set Methods
            // Lecture 55: Properties



            ////////// Lecture 52: Creating a Class //////////
            Student s1 = new Student("Bob", "Bobby",18, 65);  //V1   //create a student object; one version of the student blueprint
            
            //s1.name = "Bob";  //s1. után látszanak: Name, Age, FinalGrade
            //s1.age =15;
            //s1.finalGrade = 65; //Student 1
            s1.SayHello();  //s1. után SayHello megjelenik, ami a student class-ban van.

            // a constructor nélküliben ha kihagy név, nem jelez.
            //I can't force the user to enter in a name, because it's just a variable and anyone has access ti it.

            Student s2 = new Student("Frank", "Franky", 12, 90);  //V1  //ha kihagyod nevet, akkor constructor miatt error lesz
            //s2.name = "Frank";
            //s2.age = 12;
            //s2.finalGrade = 90; //Student 2
            s2.SayHello();

            Student s3 = new Student("Ted", "Teddy", 15, 95);  //V1
            //s3.name = "Ted";
            //s3.age = 15;
            //s3.finalGrade = 95; //Student 3
            s3.SayHello();

            Student s4 = new Student("Zsolt", "Zsolti", 32);  //V2
            s4.SayHello();

            //Console.WriteLine(s1.name);  // private után nem elérhető!!!

            ////////// Lecture 53: Constructors ////////
            // a constructor is a special type of method (method, function, some type of action)
            // the constructor is basically the parameters for the entire class.
            // Same thing works with when I build a function, the parameters are the required information that you need to supply the function in order to use it.


            ////////// Lecture 54: Get and Set Methods ////////// 
            //Console.WriteLine(s1.GetName());  //GetName megy, ha 18 vagy elmúlt 18

            //s1.SetName(""); //SetName-ben be lett állítva, hogy üres nem lehet 
            //Console.WriteLine(s1.GetName());
            /// Lecture 55 első 2 sorát ki kell kommentelni A: A vagy B lehet

            s1.SetAge(0); //SetAge-ben be lett állítva, hogy nulla nem lehet.
            Console.WriteLine(s1.GetAge());

            s1.SetFinalGrade(40); //65-re állítja
            Console.WriteLine(s1.GetFinalGrade());
            s1.SetFinalGrade(109); //100-ra állítja
            Console.WriteLine(s1.GetFinalGrade());

            ////////// Lecture 55: Properties //////////
            ///

            s1.Name = "";  //s1.SetName(""); helyett s1.Name = "";
            Console.WriteLine(s1.Name);  //s1. után Name felajánl 
            /// Lecture 54 első 3 sorát ki kell kommentelni B: A vagy B lehet

            s4.lastName = "ZSoltika";
            Console.WriteLine(s4.lastName);

        }
    }
}