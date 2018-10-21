# Arrays

Consider the following starter code:

```csharp
static void Main(string[] args)
{
  var marks = new int[3]; // Declare Array with 3 elements

  marks[0] = 75;
  marks[1] = 80;
  marks[2] = 90;
            
  var mean = (float)(marks[0] + marks[1] + marks[2]) / 3;

  Console.WriteLine("Your average is: {0:0.000}", mean);
}
```

When we need to store more than one value that is part of a group of values, we use an array.  This is similar to a list in Python, but different in that you must decide on the number of values when the array is originally declared.  The array called marks is declared on **line 9**, and can contain 3 integers.  Unlike in Python, you cannot add or delete elements to/from the array.  It will always contain three values ***(initially, the values are zero in this case)*** .

Notice the use of indexes, from **lines 10 to 12** that are used to store values in the array, and on line 14 to access values in an array.

## 03-1: Student Average

1.  Modify the program so that it stores and averages 8 marks.
2.  Modify the program so that it allows the user to input the number of marks they want to store.  ***Note:  You will need to declare the marks array after this input line.***
3.  Now, with an unknown number of marks in the array, you will need to modify how you calculate the average.  ***Note:  You will need to use a loop and the idea of using an accumulator that we used in grade 11 with Python.***
