using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////Exercise2 - part 1 //////////
            ///add meg órabért, amit check-olunk, hogy 7.5 alatt nem lehet és 49 felett sem.
            
            Console.WriteLine("Enter hourly pay rate:");
            double rate = double.Parse(Console.ReadLine());
            if (rate < 7.50 || rate > 49.00)
            {
                Console.WriteLine("Invalid rate");
            }
            else
            {
                Console.WriteLine("The rate is valid");
            }


            //////////Exercise2 - part 2 //////////
            /// ad meg a hosszúságot és szélessgéet. 
            /// 3 árkateógria van. 
            /// 400 negyzetméter alatt: 25. 400 és 600 között: 35. és 600 felett már 50.
            /// a megadott adatok alapján mond meg, hogy mennyi a heti díj és mennyi lesz a szezonra, ami 20 hét. 
            /// 
            Console.WriteLine("Enter the length of your yard");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of your yard");
            int width = int.Parse(Console.ReadLine());
            int squareFeet = width * length;
            int weeklyPrice;

            if (squareFeet < 400)
            {
                weeklyPrice = 25;
            }
            else if (squareFeet >= 400 && squareFeet < 600)
            {
                weeklyPrice = 35;
            }
            else
            {
                weeklyPrice = 50;
            }

            Console.WriteLine("The weekly fee is {0}", weeklyPrice);
            Console.WriteLine("The 20 week season price is: {0}", weeklyPrice * 20);

            //////////Exercise2 - part 3 //////////
            ///

            Random randonGenerator = new Random();
            int randomNumber = randonGenerator.Next(1,11);  //1 és 10 között véletlenszerű egész szám generálása
            Console.WriteLine(randomNumber); // itt csak kiiratjuk, hogy tesztelni tudjuk 

            Console.WriteLine("Guess a randm Number!");
            int userGuess = int.Parse(Console.ReadLine());  //user-től kérünk egy egész számot

            Console.WriteLine("The random number was {0}", randomNumber);  //megmondjuk mennyi volt a generált véletlen szám

            if (userGuess > randomNumber)  //összehasonlítjuk, hogy nagyobb, kisebb vagy egyenlő volt a megadott és a generált szám.  
            {
                Console.WriteLine("Your guess was too high.");
            }
            else if (userGuess < randomNumber)
            {
                Console.WriteLine("Your guess was too low.");
            }
            else 
            {
                Console.WriteLine("Your guess was correct.");
            }



        }
    }
}
