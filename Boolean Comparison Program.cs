using System;

class Program
{
    static void Main(string[] args)
    {
        // Boolean comparison using a while loop
        int counter = 0;
        Console.WriteLine("Using while loop:");
        while (counter < 5) // Boolean comparison: counter < 5
        {
            Console.WriteLine("Counter is " + counter);
            counter++;
        }

        // Boolean comparison using a do-while loop
        int userInput;
        Console.WriteLine("\nUsing do-while loop:");
        do
        {
            Console.Write("Enter a number less than 10 to continue (10 or more to stop): ");
            string input = Console.ReadLine();
            bool isValid = int.TryParse(input, out userInput);

            if (!isValid)
            {
                Console.WriteLine("Invalid input, please enter a number.");
                userInput = 0; // default to keep loop going
            }

        } while (userInput < 10); // Boolean comparison: userInput < 10

        Console.WriteLine("Program ended.");
    }
}
