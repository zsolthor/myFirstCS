using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fromLecture15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lecture 15: If Statements
            //Lecture 16: If-Else Statements
            //Lecture 17: Compound Expressions in If Statement
            //Lecture 18: Switch statement
            //Lecture 19: Conditional and Not Operators

            //////////Lecture 15: If Statements//////////
            int age = 5;
            bool myBool15 = false;
            if (myBool15)    //age < 10 vagy myBool15 simán if (myBool15)
            { 
            Console.WriteLine("Age is less than 10");
            Console.WriteLine("Wow You are Young");
            }

            //Use if to specify a block of code to be executed, if a specified condition is true
            //Use else to specify a block of code to be executed, if the same condition is false
            //Use else if to specify a new condition to test, if the first condition is false
            //Use switch to specify many alternative blocks of code to be executed

            //////////Lecture 16: If-Else Statements//////////
            Console.WriteLine("Enter Your Age:");
            int age15_2 = int.Parse(Console.ReadLine());

            if (age15_2 >= 18)
            {
                Console.WriteLine("You are good to go");
            }
            else
            {
                Console.WriteLine("You are to Young");
            }


            if (age15_2 == 1)
            {
                Console.WriteLine("You are 1");
            }
            else if (age15_2 == 2)
            {
                Console.WriteLine("You are 2");
            }
            else if (age15_2 == 3)
            {
                Console.WriteLine("You are 3");
            }

            //////////Lecture 17: Compound Expressions in If Statement//////////
            
            // && and operator
            bool x17 = true;
            bool y17 = true;
            bool z17 = x17 && y17;

            // || or operator 
            bool z17_1 = x17 || y17;

            Console.WriteLine("Enter Your Age:");
            int age17 = int.Parse(Console.ReadLine());
            if (age17 >= 18 && age17 <= 55)
            {
                Console.WriteLine("Good to go!");
            }
            else
            {
                Console.WriteLine("There is some problem. ");
            }


            Console.WriteLine("IMDB Enter Your Age:");
            int age17_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("IMDB What is the movie rating?");
            Char rating = char.Parse(Console.ReadLine());

            if (age17_1 <= 12 || age17_1 >= 65 && rating == 'G')  //((age17_1 <= 12 || age17_1 >= 65) && rating == 'G')
            {
                Console.WriteLine("Discount applies");
            }
            // 2   D   --> discount applies
            // 15  G   --> ---
            // 65   D   --> ---
            // 65   G   --> discount applies


            //////////Lecture 18: Switch statement//////////
            Console.WriteLine("Enter Year:");
            int year = int.Parse(Console.ReadLine());

            switch (year)
            {
                case 1:
                    {
                        Console.WriteLine("Freshman");
                        break;  //kell a break a c#-ban // A break can save a lot of execution time because it "ignores" the execution of all the rest of the code in the switch block.
                    }
                case 2:
                    {
                        Console.WriteLine("Sophomore");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Junior");
                        break;
                    }

                case 4:
                    {
                        Console.WriteLine("Senior");
                        break;
                    }
                default:  // The default keyword is optional and specifies some code to run if there is no case match
                {
                        Console.WriteLine("Invalid Year");
                        break;
                    }               //1 - case1, 2 - case2, 3 - case3, 4 - case4, other values - default
                    
            }


            //////////Lecture 19: Conditional and Not Operators//////////
            // (condition) ? true : false
            // variable             = (condition)   ?   expressionTrue :  expressionFalse;
            // int biggestNumber    = x19 > y19     ?   x19 : y19;
            // There is also a short-hand if else, which is known as the ternary operator because it consists of three operands. 
            // It can be used to replace multiple lines of code with a single line. It is often used to replace simple if else statements
            // Short Hand If...Else (Ternary Operator)

            int x19 = 7;
            int y19 = 6;

            int biggestNumber = x19 > y19 ? x19 : y19;
            //ha a kondició x nagyobb mint y, akkor kérdőjel utáni x lesz, ha hamis akkor y 
            // (condition) ? true : false
            Console.WriteLine(biggestNumber); //kiiratjuk az értéket

            double testScore = 59.6;
            Console.WriteLine((testScore >= 60)  ? "pass" : "fail");  //itt pass vagy fail lesz kiiratva



            // Not operator 
            // int myInt = 5;
            // if (!(myInt >=6))
            //{
            //
            //}

        }
    }
}
