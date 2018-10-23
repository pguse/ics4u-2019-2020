# Working with Numbers

## Exercises

## 01-1: Student Average

1.  In Visual Studio Code, create a folder called **StudentAverage** and then run the command dotnet new console in the terminal/console window. 
2.  Modify the **Main()** function with the following starter code

```csharp
static void Main(string[] args)
{
    var mark1 = 75;
    var mark2 = 85;
    var mark3 = 90;
    // Casting - Sum of Integers to Float
    var mean = (float)(mark1 + mark2 + mark3) / 3;

    Console.WriteLine("Your average is: {0:0.00}", mean);
    //Console.WriteLine(mean.GetType());
}
```

3.  Modify the program so that the user can **input** any three marks.
4.  Output the average with **no decimal places**.
