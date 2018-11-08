# Sorting

Given an array of numbers called **myArray** with indexes 0 to 6:

| 0 | 1 | 2 | 3 | 4 | 5 | 6 |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| 76 | 25 | 5 | -17 | 34 | 10 | 2 |

If we wanted to sort the array, what **steps / algorithm** could we use to arrange the numbers in order from least to greatest? One method is called the **selection sort** .

### The Selection Sort \(algorithm\)
<a href="http://www.youtube.com/watch?feature=player_embedded&v=f8hXR_Hvybo " target="_blank"><img align="right" src="http://img.youtube.com/vi/f8hXR_Hvybo/0.jpg" alt="Selection Sort" width="240" height="180" border="10" /></a>

The selection sort involves scanning the array from the beginning to find the position of the **minimum** value, then placing the minimum value at the beginning of the array, by **swapping** the two values. This is **repeated** , now starting at the next position in the array. Find the **minimum** value in the remainder of the array and swap the two values. Repeat until you have passed through the entire array. Click on the image ***(at right)*** to watch a video explaining the selection sort. 

After the first pass through the array the **minimum** value found will be **-17**. The C# code to find the **index** of the **minimum** value in the array is

```csharp
static void Main(string[] args)
{
    var myArray = new int[] {76,25,5,-17,34,10,2};
    var minIndex = 0;
    
    for(var i=0; i < myArray.Length; i++){
        if (myArray[i] < myArray[minIndex]){
            minIndex = i;
        }
    }
    Console.WriteLine(myArray[minIndex]);
}
```

The Console.WriteLine() statement is used to check whether we have found the correct minimum value.  The values in **position 0 and position 3** will now be swapped.


| 0 | 1 | 2 | 3 | 4 | 5 | 6 |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| **76** | 25 | 5 | **-17** | 34 | 10 | 2 |

 The C# code to swap the two values is
 
```csharp
static void Main(string[] args)
{
    var myArray = new int[] {76,25,5,-17,34, 10,2};
    var minIndex = 0;
    
    for(var i=0; i < myArray.Length; i++){
        if (myArray[i] < myArray[minIndex]){
            minIndex = i;
        }
    }
    swap = myArray[0];
    myArray[0] = myArray[minIndex];
    myArray[minIndex] = swap;
    
    printArray(myArray);
}

static void printArray(int[] a){
    for(var i=0; i < a.Length; i++){
        Console.Write("{0} ",a[i]);
    }
    Console.WriteLine();
}
```

**Notice** that myArray\[0\] must first be saved using another variable so that its value is not **'lost'** during the assignment statement in line 2.  The new list looks like this,

| 0 | 1 | 2 | 3 | 4 | 5 | 6 |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| **-17** | 25 | 5 | **76** | 34 | 10 | 2 |

To sort the remainder of the list, the same algorithm is followed **starting at index 1**, so for the next pass the C# code would be,

```csharp
minIndex = 1;
for(var i=2; i < mylist.Length; i++){
    if (myArray[i] < myArray[minIndex]){
        minIndex = i;
    }
}

swap = myArray[1];
myArray[1] = myArray[index];
myArray[index] = swap;

printArray( myArray );
```

The new array looks like this after the second pass through,

| 0 | 1 | 2 | 3 | 4 | 5 | 6 |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| -17 | **2** | 5 | 76 | 34 | 10 | **25** |

We continue to **repeat** these pieces of code where minIndex is assigned values from 2 to 5, where 5 is the second last index of the array.  If you look at the pattern of the index values in the code above, it should be evident that we could simply use a second loop as follows,

```csharp
static void Main(string[] args)
{
    var myArray = new int[] {76,25,5,-17,34,10,2};
    int minIndex;
    int swap;
    
    for(var j=0; j < myArray.Length; j++){
        minIndex = j;
        for(var i=j+1; i < myArray.Length; i++){
            if (myArray[i] < myArray[minIndex]){
                minIndex = i;
            }
        }
        
        swap = myArray[j];
        myArray[j] = myArray[minIndex];
        myArray[minIndex] = swap;
    
        printArray(myArray);
    }
}

static void printArray(int[] a){
    for(var i=0; i < a.Length; i++){
        Console.Write("{0} ",a[i]);
    }
    Console.WriteLine();
}
```

This code can be found in the **Selection** folder.  The **print\( myArray \)** statement simply shows the array after each pass through.  It can be moved outside the loop once you are convinced that the code works.

## Exercises

## 05-1: Bubble Sort
<a href="http://www.youtube.com/watch?feature=player_embedded&v=8Kp-8OGwphY " target="_blank"><img align="right" src="http://img.youtube.com/vi/8Kp-8OGwphY/0.jpg" alt="Selection Sort" width="240" height="180" border="10" /></a>

Write a function called **bubSort(int[] a)** that sorts an **array of integers** called **a**.  Click on the image ***(at right)*** to watch a video explaining the bubble sort.


