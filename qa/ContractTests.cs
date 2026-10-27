using System;
using Exercise6;
using Exercise6_2;
using Exercise6_3;
using fromLecture56;
using fromLecture57;

// Offline behavior checks compile the ORIGINAL learning classes, without NuGet or mocks.
// This is a bounded exercise-level contract suite, not a full solution or GUI regression.
internal static class ContractTests
{
    private static int checks;
    private static int failed;

    private static void Check(bool condition, string label)
    {
        checks++;
        if (!condition)
        {
            failed++;
            Console.Error.WriteLine("FAIL: " + label);
        }
    }

    private static bool Near(double actual, double expected)
    {
        return Math.Abs(actual - expected) < 0.000001;
    }

    public static int Main()
    {
        var square = new Square(7);
        Check(square.Side == 7, "Square.Side");
        Check(square.Area == 49, "Square.Area");
        Check(new Square(0).Area == 0, "Square zero area");

        var taxpayer = new Taxpayer();
        taxpayer.SocialSecNumber = "test-only";
        Check(taxpayer.SocialSecNumber == "test-only", "Taxpayer id");
        taxpayer.YearlyGrossIncome = 29999;
        Check(Near(taxpayer.TaxOwed, 4499.85), "Taxpayer below 30000");
        taxpayer.YearlyGrossIncome = 30000;
        Check(Near(taxpayer.TaxOwed, 8400), "Taxpayer at 30000");
        taxpayer.YearlyGrossIncome = 0;
        Check(Near(taxpayer.TaxOwed, 0), "Taxpayer update to zero");

        var job = new Job("design", 2, 100);
        Check(Near(job.TotalFee, 200), "Job initial total");
        job.TimeToComplete = 3;
        Check(Near(job.TotalFee, 300), "Job recalculate hours");
        job.HourlyRate = 50;
        Check(Near(job.TotalFee, 150), "Job recalculate hourly rate");
        var combined = new Job("A", 2, 100) + new Job("B", 3, 50);
        Check(combined.JobDesc == "A and B", "Job addition description");
        Check(Near(combined.TotalFee, 375), "Job addition total fee");

        var account1 = new BankAccount(100, "Alice");
        var account2 = new BankAccount(50, "Bob");
        var combinedAccount = account1 + account2;
        Check(Near(combinedAccount.Money, 150), "BankAccount addition money");
        Check(combinedAccount.Owner == "Alice+Bob", "BankAccount addition owner");
        Check(Near((account1 + 25).Money, 125), "BankAccount numeric addition");
        Check(Near(account1.Money, 100), "BankAccount original unchanged");

        var startCount = Person.Count;
        var person = new Person("Eva", 20);
        Check(Person.Count == startCount + 1, "Person static count increments");
        Check(person.Name == "Eva" && person.Age == 20, "Person initial properties");
        person.Name = "Anna";
        person.Age = 21;
        Check(person.Name == "Anna" && person.Age == 21, "Person mutable properties");

        Console.WriteLine("QA_MYFIRSTCS_CONTRACT: " + (checks - failed) + "/" + checks + " checks");
        return failed == 0 ? 0 : 1;
    }
}
