# The Tech Academy C# Projects
This repository contains my C# console application projects from The Tech Academy. These projects were built in Visual Studio as part of drills and exercises to practice C# fundamentals.

## Projects
The following files demonstrate small programs and drills that cover basic C# concepts:

* [Anonymous Income Comparison Program](https://github.com/bradleysundberg/The-Tech-Academy-C-Sharp-Projects/tree/main)
* [Arrays](https://github.com/bradleysundberg/The-Tech-Academy-C-Sharp-Projects/blob/main/Arrays.cs)
* [Boolean Comparison Program](https://github.com/bradleysundberg/The-Tech-Academy-C-Sharp-Projects/blob/main/Boolean%20Comparison%20Program.cs)
* [Car Insurance Approval Program](https://github.com/bradleysundberg/The-Tech-Academy-C-Sharp-Projects/blob/main/Car%20Insurance%20Approval%20Program.cs)
* [Student Daily Report Program](https://github.com/bradleysundberg/The-Tech-Academy-C-Sharp-Projects/blob/main/Student%20Daily%20Report%20Program.cs)
* [Loops](https://github.com/bradleysundberg/The-Tech-Academy-C-Sharp-Projects/blob/main/Loops.cs)
* [Shipping Quote Program](https://github.com/bradleysundberg/The-Tech-Academy-C-Sharp-Projects/blob/main/Shipping%20Quote%20Program.cs)

# Anonymous Income Comparison Program
* Purpose: Compare two users’ annual incomes based on hourly rate and hours worked.

* How it works: The program prompts the user (Person 1) to enter their hourly rate and hours worked per week. It reads values from the console and converts them to numeric types (usually int or double). It calculates the annual income using a simple formula:
```csharp
annualIncome = hourlyRate * hoursPerWeek * 52;
```
(52 weeks in a year). The program repeats the input and calculation for Person 2. Finally, it compares the two annual incomes and prints which one is higher (or if they are the same).

* Concepts covered: User input/output, type conversion, arithmetic operations, comparison operators.

# Arrays
* Purpose: Demonstrate how to declare, populate, and work with arrays.

* How it works: The program creates an array of a specific type (e.g., int[], string[]). It either initializes the array with a set of values or asks the user to input values. It often uses a for or foreach loop to iterate through the array elements. It prints each element to the console or performs operations on them (like summing values, searching for a match, etc.).

* Concepts covered: Array declaration, indexing, loops, iteration, and basic array manipulation.

# Boolean Comparison Program
* Purpose: Practice boolean logic and comparisons.

* How it works: The program prompts the user for one or more values (e.g., ages, numbers, strings). It evaluates one or more Boolean expressions, such as:
```
bool result = number1 > number2;
```
It displays the boolean result (true or false) in the console. It may combine comparisons with logical operators such as && (AND) or || (OR) to express compound conditions.

* Concepts covered: Boolean expressions, comparison operators, logical operators, and console output.

# Car Insurance Approval Program
* Purpose: Practice decision-making with conditionals to determine whether a candidate qualifies for insurance.

* How it works: The program asks the user a series of questions (e.g., age, whether they have a driver’s license, car make/model). It evaluates each answer against eligibility criteria such as “must be at least 18 years old.” Based on the answers, it prints a result like “Qualified” or “Not qualified to receive insurance.”

* Concepts covered: User input, conditional statements (if, else if, else), and basic input validation.

# Student Daily Report Program
* Purpose: A “Daily Report” console input program.

* How it works: Prompts the user with a series of questions: “What is your name?”, “What course are you on?”, “What page number are you on?” Reads and stores user input. Outputs a formatted summary confirming the responses.

* Concepts covered: String variables, console input/output, and simple data collection.

# Loops
* Purpose: Practice loops, arrays, and lists.

* How it works: Repeatedly asks the user to enter text, then appends that text to every string in a fixed array of greeting messages ("Hello", "Welcome", etc.) Shows and searches a list with duplicates. Contains multiple lists of items that includes repeated items (Apple, Banana, …) Lets the user search for any text → finds and reports the first matching position (case-insensitive). Detects and highlights duplicates using HashSet. Runs in an infinite loop until the user types "exit".

* Concepts covered: Loop styles, linear search, duplicate detection with HashSet.
