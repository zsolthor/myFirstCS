using System;

namespace Exercise6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ////////// Lecture 60 //////////
            Square[] squares = new Square[10]; //we have 10 squares

            for (int i = 0; i < 10; i++)
            {
                squares[i] = new Square(i + 1);  // new Square(i+1) squares objects with sides that have values of 1 through 10.
                Console.WriteLine("length of the square's side is: {0} and the area is {1}", squares[i].Side, squares[i].Area);
            }

            //for (int i = 1, i < 11; i++)
            //{
            //    squares[i-1] = new Square(i);
            //} //felső vagy ez.
        }
    }
}