using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////// Exercise 3_1: //////////
            ///ask the payrate until the value will be valid
            double payRate;

            do
            {
                Console.WriteLine("Please enter a valid payrate.");
                payRate = double.Parse(Console.ReadLine());
            } while (payRate < 5.65 || payRate > 49.99);

            Console.WriteLine("The valid payrate that you entered is: {0}",payRate);


            ////////// Exercise 3_2: //////////
            ///sums the integer from 1 to 50
            int sum = 0;

            for (int i = 1; i <= 50; i++)
            {
                sum += i;
            }

            Console.WriteLine("the sum is: {0}",sum);


            ////////// Exercise 3_3: //////////
            ///random number

            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);
            int userGuess;
            int amountOfGuesses = 0;
            do
            {
                Console.WriteLine("Guess a random Number: \"some help {0}\"",randomNumber);
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess < randomNumber)
                {
                    Console.WriteLine("Your guess was too low.");
                }
                else if (userGuess > randomNumber)
                {
                    Console.WriteLine("Your guess was too high.");
                }
                else
                {
                    Console.WriteLine("Your guess was correct.");
                }
                amountOfGuesses++;

            } while (userGuess != randomNumber);
            Console.WriteLine("Your number of guesses was: {0} ",amountOfGuesses);

        }
    }
}
