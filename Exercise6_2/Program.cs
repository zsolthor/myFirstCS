using System;

namespace Exercise6_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ////////// Lecture 61 //////////

            Taxpayer[] payers = new Taxpayer[3];    //declares an array of 10 taxpayer objects--10empty slots with taxpayers
                                                    // this "new" is only being used for entire arrray

            for (int i = 0; i < payers.Length; i++)
            {
                payers[i] = new Taxpayer(); //every sinlge payer needs to be instantiated and created
                //!!!                       //each individual payer or each individual element needs to be called

                Console.WriteLine("Enter Payer #{0} SSN", i + 1);  //ask SSN
                payers[i].SocialSecNumber = Console.ReadLine();  //user enter SSN number -- string

                Console.WriteLine("Enter Payer #{0} yearly income", i + 1);  //ask yearly income
                payers[i].YearlyGrossIncome = double.Parse(Console.ReadLine());  //user enter how much money they made that year
            }

            for (int i = 0; i < payers.Length; i++)  //seperate llop will be responsible for printing now all the information for every taxpayer
            {
                Console.WriteLine("Tax Payer #{0}, SSN = {1}, Income = {2}, Tax Owed = {3}", i + 1, payers[i].SocialSecNumber, payers[i].YearlyGrossIncome, payers[i].TaxOwed);
            }
        }
    }
}