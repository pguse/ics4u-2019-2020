# Functions

Our focus in this course is to create modular code.  One way we can accomplish this is to organize our code into functions.  Here is an example ***(see the given file - Program.cs)*** of using a function in our student information program:

```csharp
using System;

namespace StudentAverageArrayFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var marks = new int[] { 75, 80, 90 }; // Declare Array with 3 elements
            Console.WriteLine("Your average is: {0:0.000}", Mean(marks));
        }

        static float Mean(int[] a)
        {
            var sum = 0;
            for (var i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            return (float)sum / a.Length;
        }
    }
}
```
Notice the creation of the function:  **Mean()**.  It has a few characteristics that need to be pointed out.  First, the word **static** is necessary but will be explained later.  More importantly, notice the **return type** ... in this case **float**.  Also notice that in this example there is one **parameter** required ... an **array of integers** called **a**.  The value of the calculation is returned from the function using the keyword **return**.  If you look in the **Main()** function, the **Mean()** function acts like a variable except that an array called marks is passed into it.  Its return value is output using the **WriteLine()** function.
Functions can exist that do not return values.  An example is the **Main()** function we have been using in all our programs.  Its **return type** is **void** because there is no value returned from it.

## Exercises

Create a folder called MyMath and a new console application within it.  Create the following functions and implement / use them in the Main() function.

## 04-1: Slope
Write a function called **Slope(int x1, int y1, int x2, int y2)** that calculates and **returns a float** representing the slope of a line passing through the points (x1,y1) and (x2,y2).

## 04-2: Hypotenuse
Write a function called **Hypotenuse(int a, int b)** that calculates and **returns a float** representing the hypotenuse of a right triangle with sides a and b.

## 04-3: Distance
Write a function called **Distance(int x1,int y1,int x2,int y2)** that calculates and **returns a float** representing the distance between the points (x1,y1) and (x2,y2).

## 04-4: Prime
Write a function called **IsPrime(num)** that determines whether a number num is prime and **returns a bool value** ... either **True or False** . 

## 04-5: Greatest Common Divisor
Write a function called **Gcd(int m,int n)** that **returns an int** representing the greatest common divisor of the numbers m and n, assuming m > n. The best-known algorithm for finding a greatest common divisor is Euclid’s Algorithm. Euclid’s Algorithm states that the greatest common divisor of two integers m and n is n if n divides m evenly. However, if n does not divide m evenly, then the answer is the greatest common divisor of n and the remainder of m divided by n.

