# Functions

Our focus in this course is to create modular code.  One way we can accomplish this is to organize our code into functions.  Here is an example ***(see the given file - example.cs)*** of using a function in our student info. program:

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

## 04-1 
