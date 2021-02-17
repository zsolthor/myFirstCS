using System;

namespace Exercise4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Lecture 37 - Exercise4 - 1
            // Lecture 38 - Exercise4 - 2
            // Lecture 39 - Exercise4 - 3

            ////////// Lecture 37 - Exercise4 - 1 //////////
            ///szállítunk-e a megadott irányitószámra

            bool found = false;

            string[] zipCodes = { "10000", "10001", "10100", "10200", "103300", "10200", "15500", "80000", "80000", "90000", "18900", };
            Console.WriteLine("Enter ZIP code:");
            string code = Console.ReadLine();

            for (int i = 0; i < zipCodes.Length; i++)
            {
                if (code == zipCodes[i])
                {
                    found = true;
                }
            }

            if (found == true)
            {
                Console.WriteLine("We ship to this zip code");
            }
            else
            {
                Console.WriteLine("We does NOT ship to this zip code");
            }

            ////////// Lecture 38 - Exercise4 - 2 //////////
            ///tanár hozzáadja neveket  és osztályzatokat, ő mondja meg mennyi diákot
            ///diákok létre lesznek hozva és osztályzatok is. Az átlagot és a legjobb osztályzat meg kell jeleníteni, lkegjobb osztályzatot a névvel együtt.

            Console.WriteLine("Enter the amount of students in Your class:");
            int amountOfStudents = int.Parse(Console.ReadLine());  //megkérdezzük mennyi az osztály létszámunk

            double averageGrade = 0;
            double highestGrade = 0;
            string highestGradeName = "";  // változok átlaghoz, legjobb osztéályzathoz és legjobb eredményt elért név

            string[] studentNames = new string[amountOfStudents];
            double[] grades = new double[amountOfStudents]; // Array létrehozva diákoknak és osztályzatoknak

            for (int i2 = 0; i2 < amountOfStudents; i2++)
            {
                Console.WriteLine("Enter students #{0} name", i2 + 1);
                string name = Console.ReadLine();
                studentNames[i2] = name; //megkérdezzük student nevét +1 kell, mert 0 az első elem

                Console.WriteLine("Enter student #{0} grade", i2 + 1);
                double grade = double.Parse(Console.ReadLine());
                grades[i2] = grade;  //név után egyből kérdezzük osztályzatot

                averageGrade += grade;  // a for ciklusban osztályzatok össze lesznek adva

                if (grade > highestGrade)  //ha osztályzat nagyobb mint eddig legnagyobb, akkor
                {
                    highestGrade = grade;  //a legnagyobb osztályzat lesz, amga az osztályzat
                    highestGradeName = name; //elmentjük a student nevét  Itt még mondog for ciklusban vagyunk
                }
            }

            //double average = averageGrade / amountOfStudents;    //ez is egy módszer
            averageGrade /= amountOfStudents; //az összeget elmentettük már for ciklusban, msot elosztjuk a stdentek számával
            Console.WriteLine("The average grade is: {0}", averageGrade);
            Console.WriteLine("The highest grade is: {0} and their name was: {1}", highestGrade, highestGradeName);

            ////////// Lecture 39 - Exercise4 - 3 //////////
            ///

            ////// kiegészítés feladathoz:
            //string s = "Hello";
            //Console.Write(s[0]); // hozzáferhetünk egy string első karakteréhez
            //if (s.Contains("H")) // tartalmaz-e H karaktert a string
            //{
            //}
            //s.Remove(0, 1); //melyik karaktertől, menniyt távolítson el
            //s.Insert(0, "H"); //melyik helyre, mit helyezzen be
            //Console.WriteLine("X darab karaktert tartalmaz: {0}", s.Length);

            // get random word stuff
            //string[] words = { "jump", "programming", "sky", "pictures", "river", "start", "grass", "google" };  //meghatározzuk a szókat, amit ki kell találni
            string[] words = { "kiskutya", "narancs", "lekvár", "szivacs", "monitor", "lépegetés", "fürdés", "számitógép" }; // vagy ez a sor magyar vagy felső angol, csak bemutatás miatt
            Random random = new Random();
            int randomIndex = random.Next(0, 8); // generál egy véletlen számot 0...7 között, ez ugye index

            string selectedWord = words[randomIndex]; //a words arrayből a random szám alapjáűn kiválaszt egy számot
            string hiddenword = "";

            for (int i3 = 0; i3 < selectedWord.Length; i3++)
            {
                hiddenword += "*";
            }
            Console.WriteLine(hiddenword);  // for ciklus 0-tól a véletlen kiválasztott szó karakterszámáig létrehoz egy ******** szót

            // guessing stuff
            while (hiddenword.Contains("*")) // a while addig fut, amíg van * karaterünk
            {
                Console.WriteLine("Word: {0}", hiddenword); //kiiratjuk a *****-os szót
                Console.Write("Guess a letter >> "); // tippelni kell egy betűre
                char letter = char.Parse(Console.ReadLine()); //amit karakterként tárolunk
                bool containsLetter = false;

                for (int i31 = 0; i31 < selectedWord.Length; i31++) //for ciklus végig megy minden betün 0-tól a kiválasztott szó karakterszám végéig
                {
                    if (selectedWord[i31] == letter)  //ha a karakter a szóban és a karakter, amit megadtunk tipp-nek megegyezik akkor ...
                    {
                        hiddenword = hiddenword.Remove(i31, 1);                  //... eltávolítunk egy csillagot i31 helyről, 1 karakter-t
                        hiddenword = hiddenword.Insert(i31, letter.ToString());  // és i31-es helyre a karakter-t behelyezzük ,amit tippeltünk
                        containsLetter = true;                                  // találatot rögzítjük egy bool változóba --> true lesz
                    }
                } //for ciklus vége itt

                if (containsLetter == true) //ha volt találat
                {
                    Console.ForegroundColor = ConsoleColor.Green; // találat esetén zöld betű
                    Console.WriteLine("Yes! {0} is in the word", letter); // kiratjuk, hogy volt találat és, hogy melyik betű
                }
                else //ha nem volt találat
                {
                    Console.ForegroundColor = ConsoleColor.Red; // ha nincs találat, akkor piros betű
                    Console.WriteLine("Sorry! {0} is NOT in the word", letter); // kiratjuk, hogy melyik betű nem volt benne
                }
                Console.ResetColor(); // színeket resetlejük
            }

            //You won
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Congratulations! You win! The word was {0}", selectedWord); //ha nincs csillag karakter, akkor nyertél
        }
    }
}