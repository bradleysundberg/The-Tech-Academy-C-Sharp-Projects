# The Tech Academy C# Projects

This repository contains my C# console application projects from The Tech Academy. These projects were built in Visual Studio as part of drills and exercises to practice C# fundamentals.

## Projects

The following files demonstrate small programs and drills that cover basic C# concepts:

* [Anonymous Income Comparison Program](https://github.com/bradleysundberg/The-Tech-Academy-C-Sharp-Projects/tree/main) -- Compare two incomes.
* [Arrays](https://github.com/bradleysundberg/The-Tech-Academy-C-Sharp-Projects/blob/main/Arrays.cs) -- Practice arrays and array operations.
* [Boolean Comparison Program](https://github.com/bradleysundberg/The-Tech-Academy-C-Sharp-Projects/blob/main/Boolean%20Comparison%20Program.cs) -- Simple Boolean logic output.
* [Car Insurance Approval Program](https://github.com/bradleysundberg/The-Tech-Academy-C-Sharp-Projects/blob/main/Car%20Insurance%20Approval%20Program.cs) -- Conditional statements using user input.
* [Student Daily Report Program](https://github.com/bradleysundberg/The-Tech-Academy-C-Sharp-Projects/blob/main/Student%20Daily%20Report%20Program.cs) -- Collects student feedback.
* [Loops](https://github.com/bradleysundberg/The-Tech-Academy-C-Sharp-Projects/blob/main/Loops.cs) -- Practices loops, lists, and user input.
* [Shipping Quote Program](https://github.com/bradleysundberg/The-Tech-Academy-C-Sharp-Projects/blob/main/Shipping%20Quote%20Program.cs) -- Simple calculation of a shipping quote.

# Anonymous Income Comparison Program
* Purpose: Compare two users’ annual incomes based on hourly rate and hours worked.

* How it works: The program prompts the user (Person 1) to enter their hourly rate and hours worked per week. It reads those values from the console and parses them into numeric types (usually int or double). It calculates the annual income using a simple formula:
```csharp
annualIncome = hourlyRate * hoursPerWeek * 52;
```
(52 weeks in a year). The program repeats the input and calculation for Person 2. Finally, it compares the two annual incomes and prints which one is higher (or if they are the same).

* Concepts covered: User input/output, type conversion, arithmetic operations, comparison operators.
