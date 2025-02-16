# C# NullReferenceException Example

This repository demonstrates a common `NullReferenceException` in C# that occurs when accessing properties of objects that might be null.  The code includes a solution using the null-conditional operator to safely handle null values.

## Bug
The `bug.cs` file contains code that throws a `NullReferenceException` when attempting to access the `MyProperty` of a potentially null `ExampleClass` instance.

## Solution
The `bugSolution.cs` file shows how to prevent the exception by using the null-conditional operator (`?.`). This operator allows you to safely access members of an object only if the object is not null. 

## How to Run
1. Clone this repository.
2. Open the project in Visual Studio or a similar IDE.
3. Build and run the solution.