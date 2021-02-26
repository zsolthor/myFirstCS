using System;
using System.Linq;

namespace fromLecture31
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Lecture 32: Creating an Array
            // Lecture 33: Using Loops with Arrays
            // Lecture 34: Searching in Array Using Loops
            // Lecture 35: Usefull Array Methods
            // Lecture 36: Multidimensional arrays

            ////////// Lecture 32: Creating an Array //////////

            int[] myArray = new int[3];     //element is an invidually item in the array.
            myArray[0] = 5;                 //sub zero
            myArray[1] = 6;
            myArray[2] = 7;                 //ha 3 van definiláva ne legyen myArray[3] = 8;

            Console.WriteLine(myArray[0]);  // --> 5

            int[] myArray2 = new int[4] { 5, 6, 7, 8 };          //érték adás is van itt
            int[] myArray3 = new int[] { 5, 6, 7, 8, 9 };    //itt nincs szám, hogy mekkora array, mert érétkadásból magától adódik
            int[] myArray4 = { 5, 6, 7 };

            ////////// Lecture 32: Using Loops with Arrays //////////

            int[] grades = { 66, 88, 95, 90, 100, 55, 99, 56 };
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

            Console.WriteLine("Az array-ben {0} elem volt összesen", grades2.Length);

            //visszafelé olvasás
            int[] grades4 = { 10, 20, 30, 40, 50, 60, 65, 70, 75, 80 };

            for (int i = grades4.Length - 1; i >= 0; i--)
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
            for (int i = 0; i < students.Length; i++)
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
                    containsP = true;  //??? p vagy nélküle?
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

            ////////// Lecture 35: Usefull Array Methods //////////

            //binary search - közepétől indul, majd mondjuk jobbra középre, stb....
            //!!!if information is ordered!!! more efficient that sequential
            int[] myArray35 = { 10, 15, 20, 30, 35, 40, 45 };
            Console.WriteLine("Enter number to check if it exists:");
            int number35 = int.Parse(Console.ReadLine());       //sequential search method -- last lecture

            int answer35 = Array.BinarySearch(myArray35, number35);     //BinarySearch-ben: (hol keresek, mit keresek)

            if (answer35 < 0)
            {
                Console.WriteLine("The number does NOT exist");     //ha nincs akkor negatív szám a visszatérés
            }
            else
            {
                Console.WriteLine("The number exist, position is: {0}", answer35);      //ha van, akkor pozitív szám a visszatérés, hogy hol található !!!nullától indul!!!
            }

            //array sort method ----------------------------------------
            int[] myArray35_1 = { 10, 5, 7, 2, 55 };
            Array.Sort(myArray35_1);        //sorba rendezés

            for (int i35_1 = 0; i35_1 < myArray35_1.Length; i35_1++)
            {
                Console.WriteLine(myArray35_1[i35_1]);
            } // --> 2,5,7,10,55

            //reverse function ----------------------------------------
            int[] myArray35_2 = { 10, 5, 7, 2, 55 };
            Array.Reverse(myArray35_2);     //forditott sorrend

            for (int i35_2 = 0; i35_2 < myArray35_2.Length; i35_2++)
            {
                Console.WriteLine(myArray35_2[i35_2]);
            }

            ////////// Lecture 36: Multidimensional arrays //////////
            int[] myArray36 = { 5, 6, 7 };      // one dimension

            //2 types: Rectangular array and Jagged array

            //Rectangular array ----------------------------------------

            int[,] myArray36_1 = new int[3, 4];      //[,] --> 2 dimensional array [3, 4] --> 3 rows, 4 columns
            myArray36_1[0, 0] = 5;                      // ****
            myArray36_1[0, 1] = 6;                      // ****
            myArray36_1[0, 2] = 7;                      // ****
            myArray36_1[0, 3] = 8;  //X and Y coordinates

            myArray36_1[1, 0] = 6;
            myArray36_1[1, 1] = 7;
            myArray36_1[1, 2] = 8;
            myArray36_1[1, 3] = 9;

            myArray36_1[2, 0] = 7;
            myArray36_1[2, 1] = 8;      // 5 6 7 8
            myArray36_1[2, 2] = 9;      // 6 7 8 9
            myArray36_1[2, 3] = 10;     // 7 8 9 10

            for (int i36_1 = 0; i36_1 < 3; i36_1++)     //nested loop
            {
                for (int j36_1 = 0; j36_1 < 4; j36_1++)
                {
                    Console.Write(myArray36_1[i36_1, j36_1]);
                }
                Console.WriteLine(); //első sor sortörés
            }

            int[,] myArray36_2 =
            { { 5,6,7,8 },
              { 5,6,7,8 },
              { 5,6,7,8 }
            };

            for (int i36_2 = 0; i36_2 < 3; i36_2++)     //nested loop
            {
                for (int j36_2 = 0; j36_2 < 4; j36_2++)
                {
                    Console.Write("{0,-2}", myArray36_2[i36_2, j36_2]);  //"{0,-2}", myArray36_2[i36_2, j36_2] space a számok közé
                }
                Console.WriteLine(); //első sor sortörés
            }

            //Jagged array ----------------------------------------

            int[][] myArray36_3 = new int[3][];  //3 sorom van, de minden sor egy külön array valahány elemmel
            //myArray36_3[0] = new int[4];
            //myArray36_3[1] = new int[10];
            //myArray36_3[2] = new int[2];
            myArray36_3[0] = new int[4] { 5, 6, 7, 8 };
            myArray36_3[1] = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            myArray36_3[2] = new int[2] { 1, 2 };  //array-ek definiálása

            for (int i36_3 = 0; i36_3 < 3; i36_3++)     //nested loop  //sorokért felelős itt
            {
                for (int j36_3 = 0; j36_3 < myArray36_3[i36_3].Length; j36_3++)
                {
                    Console.Write("{0,-2}", myArray36_3[i36_3][j36_3]);  //"{0,-2}", myArray36_2[i36_2, j36_2] space a számok közé
                                                                         // !!! myArray után itt [] [] lesz !!!
                }
                Console.WriteLine(); //első sor sortörés
            }

            // System.Linq Namespace  // Kell: !!! using System.Linq; !!! +++
            int[] myNumbersLinQ = { 5, 1, 8, 9, 2, 33, 1, 7 };
            Console.WriteLine(myNumbersLinQ.Max());  // returns the largest value  --> 33
            Console.WriteLine(myNumbersLinQ.Min());  // returns the smallest value --> 1
            Console.WriteLine(myNumbersLinQ.Sum());  // returns the sum of elements --> 66

        }
    }
}