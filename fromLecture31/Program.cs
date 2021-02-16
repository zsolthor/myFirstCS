using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fromLecture31
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lecture 32: Creating an Array
            // Lecture 33: Using Loops with Arrays 
            // Lecture 34: Searching in Array Using Loops


            ////////// Lecture 32: Creating an Array //////////

            int[] myArray = new int[3];     //element is an invidually item in the array. 
            myArray[0] = 5;                 //sub zero
            myArray[1] = 6;
            myArray[2] = 7;                 //ha 3 van definiláva ne legyen myArray[3] = 8;

            Console.WriteLine(myArray[0]);  // --> 5

            int[] myArray2 = new int[4] {5,6,7,8};          //érték adás is van itt
            int[] myArray3 = new int[] { 5, 6, 7, 8, 9};    //itt nincs szám, hogy mekkora array, mert érétkadásból magától adódik
            int[] myArray4 = { 5, 6, 7};

            ////////// Lecture 32: Using Loops with Arrays //////////

            int[] grades = {66, 88, 95, 90, 100, 55, 99, 56};
            //grades[0] += 3;
            //grades[1] += 3;
            //grades[2] += 3;
            //grades[3] += 3;
            //grades[4] += 3;  //loop nélkül....

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(grades[i]);
            }

            //how many elements are in the array: .Length
            //felül csak ötöt ír ki, de alul végig megy

            int[] grades2 = { 66, 88, 95, 90, 100, 55, 99, 56 };

            for (int i = 0; i < grades2.Length; i++)
            {
                grades2[i] += 3;
                Console.WriteLine(grades2[i]);
            }

            Console.WriteLine("Az array-ben {0} elem volt összesen",grades2.Length);


            //visszafelé olvasás
            int[] grades4 = { 10, 20, 30, 40, 50, 60, 65, 70, 75, 80 };

            for (int i = grades4.Length -1; i >= 0; i--)
            {
                Console.WriteLine(grades4[i]);
            }

            Console.WriteLine("Az grades4 array-ben {0} elem volt összesen", grades4.Length);


            //foreach sample
            int[] grades3 = { 50, 60, 70, 80, 90, 100, 110, 120 };

            foreach (int score in grades3)
            {
                Console.WriteLine(score);
            }


            ////////// Lecture 34: Searching in Array Using Loops //////////

            //string[] students = new string[4];
            string[] students = { "Bob", "Ted", "Tom", "Fred" };

            Console.WriteLine("Enter students name to search for:");
            string studentsName = Console.ReadLine();

            bool contains = false;
            for (int i =0; i < students.Length; i++)
            {
                if (studentsName == students[i])
                {
                    contains = true;
                    break;
                }  //nem ide tettük az if es else-be a FOUND és NOT FOUND, mert akkor minden elemre mondta volna, hogy külön sorba, hogy megtalálta-e vagy sem. 
                // annyira nem hatékokny, mert minden elemen végig megy. Ezért kell break. 
            }

            if (contains == true)
            {
                Console.WriteLine("The student is in the class");
            }
            else
            {
                Console.WriteLine("The student is NOT in the class");
            }

            //Parallel array --------------------------------------------------
            // !!!NEVER USED parallel array!!!

            string[] studentsP = { "Bob", "Ted", "Tom", "Fred" };
            int[] gradesP = { 77, 50, 78, 99 };  

            Console.WriteLine("Enter students name to search for:");
            string studentsNameP = Console.ReadLine();

            bool containsP = false;
            int studentGradeP = 0;

            for (int i = 0; i < studentsP.Length; i++)
            {
                if (studentsNameP == studentsP[i])
                {
                    contains = true;
                    studentGradeP = gradesP[i];
                    break;
                }  //nem ide tettük az if es else-be a FOUND és NOT FOUND, mert akkor minden elemre mondta volna, hogy külön sorba, hogy megtalálta-e vagy sem. 
                // annyira nem hatékokny, mert minden elemen végig megy. Ezért kell break. 
            }

            if (contains == true)
            {
                Console.WriteLine("The student is in the class");
                Console.WriteLine("The student grade is: {0}", studentGradeP);
            }
            else
            {
                Console.WriteLine("The student is NOT in the class");
            }




        }
    }
}
