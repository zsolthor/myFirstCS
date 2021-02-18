using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fromLecture51
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lecture 52: Creating a Class
            // Lecture 53: Constructors

            ////////// Lecture 52: Creating a Class //////////
            Student s1 = new Student("Bob", 15, 65);  //V1   //create a student object; one version of the student blueprint
            //s1.name = "Bob";  //s1. után látszanak: Name, Age, FinalGrade
            //s1.age =15;
            //s1.finalGrade = 65; //Student 1
            s1.SayHello();  //s1. után SayHello megjelenik, ami a student class-ban van. 

            // a constructor nélküliben ha kihagy név, nem jelez.  
            //I can't force the user to enter in a name, because it's just a variable and anyone has access ti it.           

            Student s2 = new Student("Frank", 12,90);  //V1  //ha kihagyod nevet, akkor constructor miatt error lesz
            //s2.name = "Frank";  
            //s2.age = 12;
            //s2.finalGrade = 90; //Student 2
            s2.SayHello();

            Student s3 = new Student("Ted",15,95);  //V1
            //s3.name = "Ted";
            //s3.age = 15;
            //s3.finalGrade = 95; //Student 3
            s3.SayHello();

            Student s4 = new Student("Zsolt", 32);  //V2
            s4.SayHello();

            //Console.WriteLine(s1.name);  // private után nem elérhető!!!

            ////////// Lecture 53: Constructors ////////
            // a constructor is a special type of method (method, function, some type of action)
            // the constructor is basically the parameters for the entire class. 
            // Same thing works with when I build a function, the parameters are the required information that you need to supply the function in order to use it.


        }



    }
}
