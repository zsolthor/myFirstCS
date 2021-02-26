using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fromLecture23
{
    class Program
    {
        static void Main(string[] args)
        {

            // Lecture 24: While Loops
            // Lecture 25: For Loops
            // Lecture 26: Do While Loops
            // Lecture 27: Nested Loops


            ////////// Lecture 24: While Loops //////////           
            // Loops can execute a block of code as long as a specified condition is reached.
            //definite
            int x24 = 0;
            while (x24 < 5)  // 0 1 2 3 4 --> 5: breaks out
            {
                Console.WriteLine("Hello");
                x24++;  //alter statement 
            }


            //Indefinite: a set of instructions is repeated until a condition is met.
            int runningTotal = 0;
            Console.WriteLine("Enter a number or -1 to quit");

            int number = int.Parse(Console.ReadLine());
            while (number != -1)
            {
                runningTotal += number;
                Console.WriteLine("Enter a number or -1 to quit");
                number = int.Parse(Console.ReadLine());
            }
            // here this is break point
            Console.WriteLine("the total is: {0}", runningTotal);

            // Definite: a set of instructions is repeated a specific number of times. It is implemented by using count-controlled loops, such as for loops.
            // Indefinite: a set of instructions is repeated until a condition is met.It is implemented by using condition-controlled loops, such as while loops

            ////////// Lecture 25: For Loops //////////
            ///When you know exactly how many times you want to loop through a block of code, use the for loop instead of a while loop.
            int x25 = 0;
            while (x25 < 5)
            {
                Console.WriteLine("Hello in the while");
                x25++;
            }


            // for (statement 1; statement 2; statement 3) 
            // {
            // code block to be executed
            // }
            //Statement 1 is executed (one time) before the execution of the code block. ONE TIME
            //Statement 2 defines the condition for executing the code block. CONDITION
            //Statement 3 is executed(every time) after the code block has been executed. EVERY TIME
            

            for (int i25 = 0; i25 < 5; i25++) // 3 components: counter control variable, condition, alter
            {
                Console.WriteLine("Hello in the for");
            }   //Definite: a set of instructions is repeated a specific number of times.


            Console.WriteLine("Enter an amount of times to print hello v2");
            int amount = int.Parse(Console.ReadLine());

            for (int i25_1 = 0; i25_1 < amount; i25_1++)
            {
                Console.WriteLine("Hello v2");
            }

            ////////// Lecture 26: Do While Loops //////////

            int x26 = 5;
            do
            {
                Console.WriteLine("hello do while");
                x26++;
            } while (x26 > 6); // one execution is guaranteed, this is the different
            // The do/while loop is a variant of the while loop. This loop will execute the code block once, before checking if the condition is true, then it will repeat the loop as long as the condition is true.
            //itt látszik, hogy x értéke 5, kiirja egyszer, 5 nem nagyobb mint 6.


            //WHILE LOOP--------------------
            Console.WriteLine("hello");             // code duplicity
            string response = Console.ReadLine();   // code duplicity

            while (response == "again")
            {
                Console.WriteLine("Hello again");   // code duplicity
                response = Console.ReadLine();      // code duplicity -- 
            }

            //DO WHILE LOOP--------------------     // itt nem kell duplikálás, egyszer mindenképp végrehajt body-ban
            string response2;
            do
            {
                Console.WriteLine("Hello again v2");
                response2 = Console.ReadLine();
            } while (response2 == "again");


            ////////// Lecture 27: Nested Loops //////////

            for (int i27 = 0; i27 < 10; i27++)
            {
                Console.Write("*"); //nincs sortörés
            }
            Console.WriteLine();
            //ezt lehetne 10x másolni, és kiegészíteni sortöréssel és akkor meglenne a 10 x 10-es kocka csillagokból


            for (int j27_1 = 0; j27_1 < 10; j27_1++)
            {
                for (int i27_1 = 0; i27_1 < 10; i27_1++)
                {
                    Console.Write("{0,-2}","*"); //nincs sortörés
                }
                Console.WriteLine();
            }

            int size = 15;  //kiegészítve, hogy mekkore legyen négyzet mérete
            for (int j27_1 = 0; j27_1 < size; j27_1++)
            {
                for (int i27_1 = 0; i27_1 < size; i27_1++)
                {
                    Console.Write("{0,-2}", "*"); //nincs sortörés és space karakter van betéve jobb oldalra, azért minusz a 2
                }
                Console.WriteLine();
            }

            // FOREACH +++
            // There is also a foreach loop, which is used exclusively to loop through elements in an array:
            // foreach (type variableName in arrayName) 
            // {
            // code block to be executed
            // }
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }  //for each string element (called i - as in index) in cars, print out the value of i.

            //BREAK, CONTINUE +++
            // The break statement can also be used to jump out of a loop.
            // The continue statement breaks one iteration (in the loop), if a specified condition occurs, and continues with the next iteration in the loop.

            int i_b = 0;
            while (i_b < 10)
            {
                Console.WriteLine(i_b);
                i_b++;
                if (i_b == 4)
                {
                    break; // jump out of a loop
                }
            }  // --> 0,1,2,3

            Console.WriteLine(); //sortörés

            int i_c= 0;
            while (i_c< 10)
            {
                if (i_c== 4)
                {
                    i_c++;
                    continue;  //breaks one iteration (in the loop)
                }
                Console.WriteLine(i_c);
                i_c++;
            }  // --> 0,1,2,3,5,6,7,8,9


        }
    }
}
