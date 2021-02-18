using System;

namespace Exercise5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Lecture 48 - Exercise5 - 1
            // Lecture 49 - Exercise5 - 2
            // Lecture 50 - Exercise5 - 3

            ////////// Lecture 48 - Exercise5 - 1 //////////
            //adj meg egy számot és 2-10ig kiírom a szorzótáblát

            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            MultiplicationTable(number);

            ////////// Lecture 49 - Exercise5 - 1 //////////
            ///egy szám négyzete és köbe

            Console.WriteLine("Enter a number:");
            int number49 = int.Parse(Console.ReadLine());

            int squared = Square(number49);
            Console.WriteLine("{0} squared is {1}", number49, squared);

            int cubed = Cube(number49);
            Console.WriteLine("{0} cubed is {1}", number49, cubed);

            ////////// Lecture 50 - Exercise5 - 1 //////////

            Sum(5);
            Sum(5, 10, 15);
            Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

            int[] myArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Sum(myArray);

        }

        /////METHODS/////
        /////////////////

        // Lecture 48 - Exercise5 - 1
        public static void MultiplicationTable(int number)
        {
            for (int i = 2; i < 11; i++)
            {
                int answer = number * i;
                Console.WriteLine("{0,2} * {1,2} = {2,2}", i, number, answer);
            }
        }

        // Lecture 49 - Exercise5 - 2

        public static int Square(int number)
        {
            int answer = number * number;
            return answer;
        }

        public static int Cube(int number)
        {
            //int answer = number * number * number;
            int answer = Square(number) * number;
            return answer;
        }

        // Lecture 50 - Exercise5 - 3

        public static void Sum(params int[] myArray)
        {
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }

            Console.WriteLine("The sum is: {0}", sum);
        }

    }
}