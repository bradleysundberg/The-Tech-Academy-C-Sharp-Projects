using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program");

        // Person 1
        Console.WriteLine("Person 1");
        Console.Write("Hourly Rate? ");
        decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Hours worked per week? ");
        decimal hoursPerWeek1 = Convert.ToDecimal(Console.ReadLine());

        // Person 2
        Console.WriteLine("Person 2");
        Console.Write("Hourly Rate? ");
        decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Hours worked per week? ");
        decimal hoursPerWeek2 = Convert.ToDecimal(Console.ReadLine());

        // Calculate annual salaries
        decimal annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52;
        decimal annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;

        // Display salaries
        Console.WriteLine("Annual salary of Person 1:");
        Console.WriteLine(annualSalary1);
        Console.WriteLine("Annual salary of Person 2:");
        Console.WriteLine(annualSalary2);

        // Compare salaries
        bool doesPerson1MakeMore = annualSalary1 > annualSalary2;
        Console.WriteLine("Does Person 1 make more money than Person 2?");
        Console.WriteLine(doesPerson1MakeMore);
    }
}
