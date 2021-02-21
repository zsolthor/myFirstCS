using System;

namespace Exercise6_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            // Lecture 62

            Job j1 = new Job("wash window", 5, 15);
            Console.WriteLine("{0}, {1}, {2}, {3}", j1.JobDesc, j1.TimeToComplete, j1.HourlyRate, j1.TotalFee);
            Job j2 = new Job("take out trash", 2, 12.5);
            Console.WriteLine("{0}, {1}, {2}, {3}", j2.JobDesc, j2.TimeToComplete, j2.HourlyRate, j2.TotalFee);

            Job j3 = j1 + j2;
            Console.WriteLine("{0}, {1}, {2}, {3}", j3.JobDesc, j3.TimeToComplete, j3.HourlyRate, j3.TotalFee);
        }
    }
}