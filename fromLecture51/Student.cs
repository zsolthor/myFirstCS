using System;

namespace fromLecture51
{
    internal class Student
    {
        ////////// Lecture 52: Creating a Class //////////
        private string name;     //ha ez private, akkor program nem látja pl: s1.Name = "Bob"; de SayHello a programban okés, mert az itt lett az osztályban megírva.
        private int age;
        private double finalGrade;

        // Lecture 55: properties --auto-implemented property
        public string lastName { get; set; }  //-olvasni és írni is lehet 
        //public string lastName { private get; set }  -- olvasni nem lehet, írni igen 
        //public string lastName { get; private set }  -- írni nem lehet, olvasni igen 
        // ki kellett több helyen egészíteni lastName-mel 
        //lecture 55 vége


        public void SayHello()
        {
            Console.WriteLine("Hello from {0}", name);
        }

        ////////// Lecture 53: Constructors ////////
        // a constructor is a special type of method (method, function, some type of action)
        // #1: constructor has no return type.
        // #2. the name of the special function is always the name of the class.
        // #3. must be public: has to be seen by things outside of the class.

        public Student(string name, string lastName, int age, double finalGrade)  //V1
        {
            this.name = name;
            this.age = age;
            this.finalGrade = finalGrade;
        }

        //overloading a constructor
        public Student(string name, string lastName, int age) : this(name, lastName, age, 0) //V2  //felső rész 3-ról 4-re nő a references
        {                                       //constructor initializer:allows us to call another constructor from a constructor
                                                //finalGrade itt default value to zero.
                                                //this.name = name;
                                                //this.age = age;
                                                //!!!itt van egy kis kód ismnétlés
        }


        ////////// Lecture 54: Get and Set Methods ////////// 
        ///name, age, finalGrade be lett állítva private-be
        ///get - ki lehet olvasni 
        ///set lehet változtatni
        ///ezek nélkül nem lehetett, mert private

        //public string GetName()
        //{
        //    if (age >= 18)
        //    {
        //        return name;
        //    }
        //    else
        //    {
        //        return "this student is too young.";
        //    }
        //}

        //public void SetName(string newName)  // nincs visszatérési értéke, ezért void
        //{
        //    if (newName != "")
        //    {
        //    this.name = newName;
        //    }
        //} // Lecture 55 public string Name ki kell kommentelni, ha ez aktív

        public int GetAge()
        {

            if (age > 18)
            {
                return age;
            }
            else
            {
                return -1;
            }
        } // ki lehet olvasni nevet, ha elmúlt 18 éves

        public void SetAge(int newAge)
        {
            if (newAge != 0)
            { 
            age = newAge;  //this.age = newAge; ez is lehetne, szerintem ez szebb
            }
        } // be lehet állítani, hogy menniy idős, ha nem nulla a megadott év

        public double GetFinalGrade()
        {
            return finalGrade;
        } // finalGrade ki lehet olvasni

        public void SetFinalGrade(double newFinalGrade)
        {
            if (newFinalGrade < 65)
            {
                newFinalGrade = 65;
            }
            else if (newFinalGrade > 100)
            {
                newFinalGrade = 100;
            }
            finalGrade = newFinalGrade;
        } // meg lehet változtatni finalGrade-t, de ha 65-nél kevesebb, akkor 65-re állítja, ha 100-nál nagyobb akkor 100-ra állítja

        ////////// Lecture 55: Properties //////////
        /// csak c#, előző máshol is

        public string Name
        {
            get
            {
                if (age >= 18)
                {
                    return name;
                }
                else
                {
                    return "this student is too young.";
                }
            }
            set
            {
                if (value != "")  // ez volt másolva előző leckéből: newName != ""
                {
                    this.name = value; // ez volt másolva előző leckéből: this.name = newName;
                } // value kell!!!
            }
        } // Lecture 54 GetName, SetName ki kell kommentelni ha ez aktív

        public int Age
        {
            get
            {
                if (age > 18)
                {
                    return age;
                }
                else
                {
                    return -1;
                }
            }
            set 
            {
                if (value != 0)
                {
                    age = value;  //this.age = newAge; ez is lehetne, szerintem ez szebb
                }
            }
        } //megírtam, de nincs használva
        public double FinalGrade
        {
            get
            {
                return finalGrade;
            }
            set
            {
                if (value < 65)
                {
                    value = 65;
                }
                else if (value > 100)
                {
                    value = 100;
                }
                finalGrade = value;
            }
        } //megírtam, de nincs használva


    }
}