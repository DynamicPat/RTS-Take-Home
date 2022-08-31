# RTS-Take-Home

## Prompt Information

Write a class in the language of your choice that contains the following two public methods:

### aboveBelow
  - Accepts two arguments
    - An unsorted collection of integers (the list)
    - An integer (the comparison value)
  - Returns a hash/object/map/etc. with the keys "above" and "below" with the corresponding count of integers from the list that are above or below the comparison value

**Example usage**:

*input*: `[1, 5, 2, 1, 10]`, `6`

*output*: `{ "above": 1, "below": 4 }`

### stringRotation
  - Accepts two arguments
    - A string (the original string)
    - A positive integer (the rotation amount)
  - Returns a new string, rotating the characters in the original string to the right by the rotation amount and have the overflow appear at the beginning

**Example usage**:

*input*: `"MyString"`, `2`

*output*: `"ngMyStri"`

## Solution install and run information

Download and Install .NET 6.0 from https://dotnet.microsoft.com/en-us/download 

Download/Clone this repository from Github at https://github.com/DynamicPat/RTS-Take-Home 

### Running the Console App

In a terminal application of your choice, navigate to the `/RTSTest` directory of this solution

Type in `dotnet run` and execute!

### Running the Tests

In a terminal application of your choice, navigate to the `/RTSTestTests` directory of this solution

Type in `dotnet test` and execute!

## Notes on the Solution

### aboveBelow

The first aboveBelow solution focused on readibility. It is written to be clear/concise for ease of maintenance and code readibility. However, its flaw is that it iterates of the list of unsorted integers *twice*, making it a sub-optimal solution if efficiency is the most important metric. If there are only ever a limited number of items in the unsorted list, then this could remain a viable option.

The second aboveBelowOptimized solution focused on making sure that the in memory list is only iterated against once, improving performance. However, with the current set of test data used, the performance difference is negligible. There isn't *too* much readability sacrificed in this example, but it does create some additional complexity during review. 

### stringRotation

This solution checks rotates the string as desired, ensuring that when the rotationAmount is beyond the length, that addtional steps are taken to understand what the rotation actually looks like. 