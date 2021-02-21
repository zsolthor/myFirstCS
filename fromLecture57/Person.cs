using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fromLecture57
{
    class Person
    {
        private string name; //name is a variable - instance variable
        private int age;

        // Lecture 59: StaticKeyword
        //anything you mark static -- it is for the entire class
        // so each instance DOES NOT have their own version of it. There's only one version of it for the entire class.
        public static int Count;  //it is applied to the entire class. every instance doesn't have a count, only the entire class has a count. 


        public Person (string name, int age)
        {
            this.name = name;
            this.age = age;
            Count++;  // if a person is created, increment count by1.
        } // constructor

        public string Name  //Name is an instance property
        {                   //instance means that it is unique to every instance of the class 
            get             //class is a blueprint -- you can create many isntances of that blueprint
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }



    }
}
