using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fromLecture51
{
    class Student
    {
        ////////// Lecture 52: Creating a Class //////////
        private string name;     //ha ez private, akkor program nem látja pl: s1.Name = "Bob"; de SayHello a programban okés, mert az itt lett az osztályban megírva.
        private int age;
        private double finalGrade;



        public void SayHello()
        {
            Console.WriteLine("Hello from {0}", name);
        }

        ////////// Lecture 53: Constructors ////////

        // a constructor is a special type of method (method, function, some type of action)
        // #1: constructor has no return type. 
        // #2. the name of the special function is always the name of the class. 
        // #3. must be public: has to be seen by things outside of the class. 

        public Student(string name, int age, double finalGrade)  //V1
        {
            this.name = name;
            this.age = age;
            this.finalGrade = finalGrade;
        }

        //overloading a constructor       
        public Student(string name, int age) :this (name, age,0) //V2  //felső rész 3-ról 4-re nő a references
        {                                       //constructor initializer:allows us to call another constructor from a constructor
                                                //finalGrade itt default value to zero. 
            //this.name = name;
            //this.age = age;
            //!!!itt van egy kis kód ismnétlés
        }



    }
}
