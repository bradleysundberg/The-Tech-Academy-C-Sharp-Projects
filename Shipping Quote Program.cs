using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Get weight
        Console.WriteLine("Please enter the package weight:");
        if (!decimal.TryParse(Console.ReadLine(), out decimal weight) || weight <= 0)
        {
            Console.WriteLine("Invalid weight entered.");
            return;
        }

        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Get width
        Console.WriteLine("Please enter the package width:");
        if (!decimal.TryParse(Console.ReadLine(), out decimal width) || width <= 0)
        {
            Console.WriteLine("Invalid width entered.");
            return;
        }

        // Get height
        Console.WriteLine("Please enter the package height:");
        if (!decimal.TryParse(Console.ReadLine(), out decimal height) || height <= 0)
        {
            Console.WriteLine("Invalid height entered.");
            return;
        }

        // Get length
        Console.WriteLine("Please enter the package length:");
        if (!decimal.TryParse(Console.ReadLine(), out decimal length) || length <= 0)
        {
            Console.WriteLine("Invalid length entered.");
            return;
        }

        // Check dimension sum
        if ((width + height + length) > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate quote
        decimal quote = (width * height * length * weight) / 100;
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!");
    }
}
