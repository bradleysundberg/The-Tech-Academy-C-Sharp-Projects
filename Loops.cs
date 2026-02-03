using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Original messages array
        string[] messages = { "Hello", "Welcome", "Goodbye", "See you", "Take care" };

        // Unique list of strings 
        List<string> uniqueMessages = new List<string> { "Sunrise", "Ocean", "Forest", "Mountain", "Desert" };

        // Duplicate list of strings 
        List<string> duplicateMessages = new List<string>
        {
            "Apple", "Banana", "Cherry", "Apple", "Date", "Banana", "Elderberry"
        };

        while (true)
        {
            // Get user input
            Console.Write("Enter some text to append to messages (or type 'exit' to quit): ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit")
            {
                Console.WriteLine("Exiting program...");
                break;
            }

            // Append input to messages array
            for (int i = 0; i < messages.Length; i++)
            {
                messages[i] += " " + userInput;
            }

            // Display modified messages
            Console.WriteLine("\nModified messages:");
            for (int i = 0; i < messages.Length; i++)
            {
                Console.WriteLine(messages[i]);
            }

            // Demonstrate loops using < and <=
            Console.WriteLine("\nLoop using '<' operator:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"< loop iteration: {i}");
            }

            Console.WriteLine("\nLoop using '<=' operator:");
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine($"<= loop iteration: {i}");
            }

            // Display duplicate list
            Console.WriteLine("\nList with duplicate strings:");
            for (int i = 0; i < duplicateMessages.Count; i++)
            {
                Console.WriteLine($"{i}: {duplicateMessages[i]}");
            }

            // Ask user to search in duplicate list
            Console.Write("\nEnter text to search in the duplicate list: ");
            string searchInput = Console.ReadLine();

            bool foundMatch = false;

            for (int i = 0; i < duplicateMessages.Count; i++)
            {
                if (duplicateMessages[i].Equals(searchInput, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Found '{searchInput}' at index: {i}");
                    foundMatch = true;
                    // Stop after first match
                    break;
                }
            }

            if (!foundMatch)
            {
                Console.WriteLine($"'{searchInput}' was not found in the list.");
            }

            // Foreach loop to detect previously seen values
            List<string> itemsWithDuplicates = new List<string>
            {
                "Dog", "Cat", "Bird", "Dog", "Fish", "Cat", "Lizard"
            };

            HashSet<string> seenItems = new HashSet<string>();

            Console.WriteLine("\nChecking for duplicate appearances in the list:");
            foreach (string item in itemsWithDuplicates)
            {
                if (seenItems.Contains(item))
                {
                    Console.WriteLine($"{item} has already appeared in the list.");
                }
                else
                {
                    Console.WriteLine($"{item} is appearing for the first time.");
                    seenItems.Add(item);
                }
            }

            Console.WriteLine(); // space before next loop
        }

        Console.WriteLine("Program has ended. Press any key to close.");
        Console.ReadKey();
    }
}
