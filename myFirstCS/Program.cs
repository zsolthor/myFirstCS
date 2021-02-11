using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstCS  //comment
{
    class Program
    {
        //Lecture 2: Declaring Variables
        //Lecture 3: Displaying Variables in the Console
        //Lecture 4: Using Arithmetic Operators
        //Lecture 5: Using Bools

        static void Main(string[] args)
        {
            //////////Lecture 2: Declaring Variables//////////
            ////int, double, string, bool, char
            //int myInt = 5; //initialization
            //myInt = 6;
            //int myInt2 = 10, myInt3 = 20;
            //int myInt4, myInt5;

            //string a = "Hello World";
            //In the above code, the variable a is declared as a string and is initialized to "Hello World".
            //var b = "hello world";
            //The var keyword specifies implicit typing.

            // 5 basic types
            int myInt = 5;
            double myDouble = 5.5;
            string myString = "Hello my world";
            bool myBool = true;
            char myChar = 'S';

            //////////Lecture 3: Displaying Variables in the Console//////////
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
            Console.WriteLine(myString);
            Console.WriteLine(myBool);
            Console.WriteLine(myChar);  //mindig új sorba írja

            Console.Write(myString);
            Console.Write(myChar);  //egy sorba írja, nincs sortörés. --> Hello my worldS

            Console.WriteLine(" The value is myInt is {0}", myInt);  //first placeholder: {0}
            Console.WriteLine("The value of myInt is {0,-6} and the value of myDouble is {1,-5}", myInt, myDouble);
            // --> The value of myInt is 4 and the value of myDouble is 5,5
            // ha a placeholder helyére {0,5} {1,2}, akkor elsőben 5 és másodikban 2 space lesz érték előtt
            // ha negatív szám, akkor nem bal oldal, hanem jobb oldalra kerül a space
            // ha myInt 55555 és {0,-5} akkor nem lesz pluszban space jobb oldalon
            // ha myInt 55555 és {0,-1} akkor nem lesz pluszban space jobb oldalon de nem lesz hiba amiatt, hogy nagyobb a szükséges hely.
            // ha myInt 55555 és {0,-6} akkor egy plusz space lesz. 
            //myInt = 55555;
            //Console.WriteLine("The value of myInt is {0,-5} and the value of myDouble is {1,-5}", myInt, myDouble);
            //Console.WriteLine("The value of myInt is {0,-1} and the value of myDouble is {1,-5}", myInt, myDouble);
            //Console.WriteLine("The value of myInt is {0,-6} and the value of myDouble is {1,-5}", myInt, myDouble);
            
            Console.WriteLine("THe value of myInt is " + myInt); //concatenation
            //https://docs.microsoft.com/en-us/dotnet/csharp/how-to/concatenate-multiple-strings#code-try-2
            Console.WriteLine("THe value of myInt is " + myInt + " and the value of myDouble is " + myDouble);
            //Console.WriteLine("The value of myInt is {0} and the value of myDouble is {1}", myInt, myDouble);
            // utolsó és utolsó előtti ugyanazt adja eredményül

            //////////Lecture 4: Using Arithmetic Operators//////////
            // + - * / % 
            int myInt4 = 5 + 5;  // 5 + 5    5-5   5 * 5
            Console.WriteLine(myInt4);

            double myDouble4 = 45 / 2;
            Console.WriteLine(myDouble4);  //--> 22 integer volt

            double myDouble4_1 = 45.0 / 2;
            Console.WriteLine(myDouble4_1);  //--> 22,5 

            double myDouble4_2 = 5 % 4;
            Console.WriteLine(myDouble4_2);  // --> 1 remain, ennyi maradt

            int myInt4_1 = 2 + 3 * 4;
            Console.WriteLine("The result is: {0}", myInt4_1);  // --> The result is: 14

            int myInt4_2 = myInt4 + myInt4_1;
            Console.WriteLine(myInt4_2);  // --> 24

            int myInt4_3 = 5;
            myInt4_3 = myInt4_3 + 1;  // x = x + 1;
            Console.WriteLine(myInt4_3);  // --> 6
            myInt4_3 += 1;  // x += 1;
            Console.WriteLine(myInt4_3);  // --> 7   
            //kettő megegyezik egymással:myInt4_3 = myInt4_3 + 1;    myInt4_3 += 1;
            myInt4_3++;  //postfix
            Console.WriteLine(myInt4_3);  // -->  8
            ++myInt4_3;  //prefix
            Console.WriteLine(myInt4_3);  // -->  9

            int myInt4_4 = 4;
            int myInt4_5 = myInt4_4++;
            Console.WriteLine("The value of myInt4_4 is: {0} and the value of myInt4_5 is: {1}", myInt4_4, myInt4_5);
            // -->  5   4   ez volt postfix
            // balról jobbra haladunk: myInt4_5 megkapja a négyet myInt4_4 utána növeli eggyel

            int myInt4_6 = 4;
            int myInt4_7 = ++myInt4_6;
            Console.WriteLine("The value of myInt4_6 is: {0} and the value of myInt4_7 is: {1}", myInt4_6, myInt4_7);
            // -->  5   5   ez volt prefix
            // balról jobbra haladunk: myInt4_7 megkapja a növelt értéket

            //////////Lecture 5: Using Bools//////////
            










        }
    }
}

/*
 * multiline 
 * commnet
 * */
