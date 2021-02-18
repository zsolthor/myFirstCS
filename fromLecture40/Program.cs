using System;

namespace fromLecture40
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //eddig a main-ben voltunk mindig
            //Console.WriteLine(); --> WriteLine is a method. //int.Parse --> method
            //Methods are sometimes also called functions

            // Lecture 41: Creating Methods
            // Lecture 42: Pass by Reference vs Pass by Value
            // Lecture 43: Ref Keyword
            // Lecture 43: Out Keyword
            // Lecture 44: Out Keyword
            // Lecture 45: Params Keyword
            // Lecture 46: Method Overloading
            // Lecture 47: Optional Parameters

            ////////// Lecture 41: Creating Methods //////////
            // public - anyone can acces and use this
            // private - only the class itself can use it (ahogy indul a class Program tudja használni)
            // Console.WriteLine(); --> Console is a class; .WriteLine is a public method
            // DisplayMessage, Add, Add2 -- 41-esben lett létrehozva

            DisplayMessage();  //a main kívül írtuk meg ezt a methodus-t, ahogy elkezdjuk gépelni, már VS mutatja a lils négyzetet, hogy elérhető, ha megvan írva.
            Console.WriteLine("TEST");  // --> "Test" a ()-ben: parameter. A mi DisplayMessage-ünknek nincs szüksége paraméterre.

            Add(5, 10);
            Add(500, 51);  //itt már van paraméter

            Add2(20, 30);
            int answer = Add2(1, 8);
            //int answer = Add(3, 8); //ha itt komment ki van szedve, akkor látszik, hogy egyből error van, mert az első Add method void típus
            Console.WriteLine(answer);

            int secondAnswer = Add2(answer, 5);  // Alt+F12 vagy jobb klikk és "Peek Definition", mutatja a kódot.
            Console.WriteLine(secondAnswer);

            //int a = int.Parse(Console.ReadLine());  //Parse, van visszatérisi értéke. Egy integer.

            ///////// Lecture 42: Pass by Reference vs Pass by Value //////////

            // Pass by Value (struct)--------------------------------------------------
            int student1Grade = 75;  // int alone is a value type //itt érték van
            Console.WriteLine("Students grade before extra credit: {0}", student1Grade);
            GiveExtraCredit(student1Grade);
            Console.WriteLine("Students grade after extra credit: {0}", student1Grade);
            /// 3 sor lesz konzolban 75, 78, 75 értékkel.
            /// inside function-ban 78
            /// main-ben, pedig 75 marad. Ez a pass by value.

            // Pass by reference (classes)--------------------------------------------------
            int[] grades = new int[1];  // integer array is a class, reference type  //new keyword -- memory location  // itt nem value, hanem memory location
            grades[0] = 75;
            Console.WriteLine("Students grade before extra credit: {0}", grades[0]);
            GiveExtraCreditArray(grades);
            Console.WriteLine("Students grade (reference) after extra credit: {0}", grades[0]);

            ///////// Lecture 43: Ref Keyword /////////
            ///ref keywords requires an initial value
            int studentGrade43 = 75;  // ha nem lenne értéke, akkor a következő hívás error-t jelezne: GiveExtraCredit43(ref studentGrade43);
            GiveExtraCredit43(ref studentGrade43);  // "ref" hozzáadva paraméterhez itt és methodusban
            Console.WriteLine(studentGrade43);

            ///////// Lecture 44: Out Keyword /////////
            ///You can use the out keyword to return more than 1 value from a method. TRUE

            int studentGrade44;  // nincs értéke, de methodus-ban kellett értéket adni error miatt
            GiveExtraCredit44(out studentGrade44);  // "out" hozzáadva paraméterhez itt és methodusban
            Console.WriteLine(studentGrade44);

            int add;
            int mult;
            AddAndMult(5, 10, out add, out mult);
            Console.WriteLine(add); // --> 15
            Console.WriteLine(mult); // --> 50

            ///////// Lecture 45: Params Keyword /////////
            ///unlimited parameters

            int[] myArray45 = { 5, 6, 7, 8, 9, 10 };
            PrintArray(myArray45);
            //Console.WriteLine("Hello {0} {1} {2} {3} {4} {5} {6}", 5, 6, 7, 8, 9, 10, 11);
            PrintArray(5, 6, 7, 8, 9, 10); //array-t vár nem különálló integer értékeket alapból. // public static void PrintArray(int[] array) //error lesz //ezárt kell: public static void PrintArray(params int[] array)
            PrintArray(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18); // minden elemet kiír itt

            ///////// Lecture 46: Method Overloading /////////

            //Console.WriteLine(  -- 19 változata van

            Add46(5, 6);
            Add46("hello", "overloading world");
            //method-oknál Add46-ra 2 verzió van
            //Add46( // mutatja hogy 2 verzió van, mint Console.WriteLine( --- 19 változata van

            Add46(5.5, 6.6);  //még error van, mert csak 2 áltozat van method részben, adjuk hozzá és eltünik
                              //hozzáadva --> 12.1 eredmény. Hozzáadás után eltünt error, már 3 verzió van

            Add46(1.1, -1.1); //másodjára van meghívva, mint double --> references mutatja is method részben

            ///////// Lecture 47: Optional Parameters /////////

            Add47(4);  //meghívtuk egy értékkel, mert y-nak adtunk method részben egy default értéket: public static void Add47(int x47, int y47 = 1)
            Add47(8, 61); //de default value-t felül lehet írni.

            Add47_1(1, 2, 3);                   // --> 6 //3értéket adtam meg = 1+2+3
            Add47_1(5, z47_1: 5);               // --> 11 //2 értéket adtam meg = 5+1+5 //y maradt default érték
            Add47_1(5, z47_1: 5, y47_1: 100);   // -->  110 //3 értéket adtam meg = 5+100+5 sorrend nem sorrendben volt
        }

        ///////////////////
        //////METHOD///////
        //////////////////

        // Lecture 41: Creating Methods
        public static void DisplayMessage()     //void -- no return type, no answer, only doing action; returning nothing
        {                                       //()-parameters, any information your method needs in order to complete the tasks
            Console.WriteLine("Hello method World!");
        }

        public static void Add(int number1, int number2)
        {
            int answer = number1 + number2;
            Console.WriteLine(answer);
        }

        public static int Add2(int number1, int number2)  //void helyett int, lesz visszatérési értéke
        {
            int answer = number1 + number2;
            return answer;
        }

        // Lecture 42: Pass by Reference vs Pass by Value
        public static void GiveExtraCredit(int studentsGrade)  // Pass by Value
        {
            studentsGrade += 3;
            Console.WriteLine("Students grade after extra credit inside function: {0}", studentsGrade);
        }

        public static void GiveExtraCreditArray(int[] grades)  // Pass by reference
        {
            grades[0] += 3;
        }

        // Lecture 43: Ref Keyword
        public static void GiveExtraCredit43(ref int studentGrade43) // "ref" hozzáadva paraméterhez itt a methodusban és meghívásnál
        {                                                               // force value type pass by reference
            studentGrade43 += 5;
        }

        // Lecture 44: Out Keyword
        public static void GiveExtraCredit44(out int studentGrade44)  // "out" hozzáadva paraméterhez itt a methodusban és meghívásnál
        {
            studentGrade44 = 2;  //kell egy érték adás, mert error volt
            studentGrade44 += 8;
        }

        public static void AddAndMult(int a, int b, out int added, out int mult)
        {
            added = a + b;
            mult = a * b;
        }

        // Lecture 45: Params Keyword
        public static void PrintArray(params int[] array) //params hozzáadva
        {
            for (int i45 = 0; i45 < array.Length; i45++)
            {
                Console.Write(array[i45]);
                Console.WriteLine();
            }
        }

        // Lecture 46: Method Overloading
        public static void Add46(int x46, int y46)                  //lent megírtuk ugyanazzala névvel, de más paraméterrel
        {
            int answer46 = x46 + y46;
            Console.WriteLine(answer46);
        }

        public static void Add46(string x46, string y46)            //ugyanazzala névvel, de más paraméterrel van megírva (lásd fent)
        {
            string answer46 = x46 + " " + y46;  //concatenation
            Console.WriteLine(answer46);
        }

        //másodjára van meghívva, mint double, ezért 2 references-t mutat. Mutatja is hol ha klikk "2 references"
        public static void Add46(double x46, double y46)            //ugyanazzala névvel, de más paraméterrel van megírva (lásd fent)
        {
            double answer46 = x46 + y46;
            Console.WriteLine(answer46);
        }

        // Lecture 47: Optional Parameters

        public static void Add47(int x47, int y47 = 1)  //mandetory , not optional     De Y-nak adunk egy default értéket. Így optional lesz.
        {                                               //Add47(4); így hívtuk meg. Már nincs error ha van default érték.
            int answer47 = x47 + y47;
            Console.WriteLine(answer47);
        }

        public static void Add47_1(int x47_1, int y47_1 = 1, int z47_1 = 2)  //mandetory , not optional     De Y-nak adunk egy default értéket. Így optional lesz.
        {                                               //Add47(4); így hívtuk meg. Már nincs error ha van default érték.
            int answer47_1 = x47_1 + y47_1 + z47_1;
            Console.WriteLine(answer47_1);
        }
    }
}