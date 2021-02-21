using System;

namespace fromLecture56
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Lecture 56: Operator Overloading

            BankAccount bank1 = new BankAccount(50, "Bob");
            BankAccount bank2 = new BankAccount(150, "Fred");

            int x = 5;
            int y = x + 5;
            string x1 = "hello";
            string y1 = "world";
            string z1 = x1 + y1;  //the plus operator does different things in different contexts and that's exactly what we ara doing.

            BankAccount bank3 = bank1 + bank2;
            // first, this is an error: bank1 + bank2 The computer does not know to do that by itself.

            Console.WriteLine(bank3.Owner);
            Console.WriteLine(bank3.Money); // --> Bob + Fred; 200

            BankAccount bank4 = bank3 + 500;  // we're going to get an error. (handle the plus operator with this class when the left and the right hand side are both bank accounts.)

            Console.WriteLine(bank4.Owner);
            Console.WriteLine(bank4.Money);  // --> Bob + Fred; 700

            //BankAccount bank5 = bank1 - bank2;  // ez még error lenne, mivel nincs meghatározva
            BankAccount bank6 = bank4 + bank1 + bank2;
            Console.WriteLine(bank6.Owner);
            Console.WriteLine(bank6.Money);


        }
    }
}