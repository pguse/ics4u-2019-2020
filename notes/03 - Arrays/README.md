# Arrays

Consider the following example code:

## Example 1:

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

When we need to store more than one value that is part of a group of values, we use an array.  This is similar to a list in Python, but different in that you must decide on the number of values when the array is originally declared.  The array called **marks** is declared on **line 9**, and can contain 3 integers.  Unlike in Python, you cannot add or delete elements to/from the array.  It will always contain three values ***(initially, the values are zero in this case because it is of type integer)*** .

Notice the use of indexes, from **lines 10 to 12** that are used to store values in the array, and on line 14 to access values in an array.

In the example above, the element are assigned values line-by-line ***(lines 10-12)***.  You can have user input values by using a for-loop that traverses the array elements using their indices.  Consider the following example code:

## Example 2:

```csharp
static void Main(string[] args)
{
  var marks = new int[3]; // Declare Array with 3 elements

  // Using a for-loop for input
  for(var i=0; i < 3; i++){
    Console.WriteLine("Enter a mark: ");
    marks[i] = int.Parse(Console.ReadLine());
  }
            
  var mean = (float)(marks[0] + marks[1] + marks[2]) / 3;

  Console.WriteLine("Your average is: {0:0.0}", mean);
  }
```

## Swapping Elements

Sometimes you need to rearrange elements in an array. You do this by swapping elements as in the following example code:

```csharp
static void Main(string[] args)
{
  var marks = new int[3]; // Declare Array with 3 elements

  marks[0] = 75;
  marks[1] = 80;
  marks[2] = 90;
  
  // swap elements 1 and 2
  var swap = marks[1];
  marks[1] = marks[2];
  marks[2] = swap;
  
  for (var i=0; i < 3; i++){
    Console.Write( "{0} ", marks[i] );
  }
  Console.WriteLine();
}
```
