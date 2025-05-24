using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. String array
        string[] stringArray = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
        Console.WriteLine("String Array: Select an index (0 to " + (stringArray.Length - 1) + "):");
        DisplayElementByIndex(stringArray);

        // 2. Integer array
        int[] intArray = { 10, 20, 30, 40, 50 };
        Console.WriteLine("\nInteger Array: Select an index (0 to " + (intArray.Length - 1) + "):");
        DisplayElementByIndex(intArray);

        // 3. String list
        List<string> stringList = new List<string> { "Red", "Green", "Blue", "Yellow", "Purple" };
        Console.WriteLine("\nString List: Select an index (0 to " + (stringList.Count - 1) + "):");
        DisplayElementByIndex(stringList);
    }

    static void DisplayElementByIndex<T>(IList<T> collection)
    {
        try
        {
            Console.Write("Enter index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index < 0 || index >= collection.Count)
            {
                Console.WriteLine("Index out of range. Please select a valid index.");
            }
            else
            {
                Console.WriteLine("Element at index " + index + ": " + collection[index]);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a numeric index.");
        }
    }
}
