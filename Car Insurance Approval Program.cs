using System;

class Program
{
    static void Main()
    {
        // Ask for the applicant's age
        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine());

        // Ask if the applicant has ever had a DUI
        Console.WriteLine("Have you ever had a DUI? (true/false)");
        bool hasDUI = Convert.ToBoolean(Console.ReadLine());

        // Ask how many speeding tickets the applicant has
        Console.WriteLine("How many speeding tickets do you have?");
        int speedingTickets = Convert.ToInt32(Console.ReadLine());

        // Determine qualification based on the rules
        bool isQualified = (age > 15) && !hasDUI && (speedingTickets <= 3);

        // Output the result
        Console.WriteLine("Qualified?");
        Console.WriteLine(isQualified);
    }
}
