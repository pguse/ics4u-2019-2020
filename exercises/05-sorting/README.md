# Sorting

<a href="http://www.youtube.com/watch?feature=player_embedded&v=f8hXR_Hvybo
" target="_blank"><img align="right" src="http://img.youtube.com/vi/f8hXR_Hvybo/0.jpg" 
alt="Selection Sort" width="240" height="180" border="10" /></a>


Given a list of numbers called **myList** with indexes 0 to 6:

| 0 | 1 | 2 | 3 | 4 | 5 | 6 |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| 76 | 10 | 5 | -17 | 34 | 25 | 2 |

If we wanted to sort the list, what **steps / algorithm** could we use to arrange the numbers in order from least to greatest? One method is called the **selection sort** .

### The Selection Sort \(algorithm\)

The selection sort involves scanning the list from the beginning to find the position of the **minimum** value, then placing the minimum value at the beginning of the list, by **swapping** the two values. This is **repeated** now starting at the next position in the list. Find the **minimum** value in the remainder of the list and swap the two values. Repeat until you have passed through the entire list.

After the first pass through the list the **minimum** value found will be **-17**. The C# code to find the **index** of the **minimum** value in the list is

```csharp
static void Main(string[] args)
{
    var myList = new int[] {76,10,5,-17,34,25,2};
    var minIndex = 0;
    
    for(var i=0; i < myList.Length; i++){
        if (myList[i] < myList[minIndex]){
            minIndex = i;
        }
    }
    Console.WriteLine(myList[minIndex]);
}

static void printArray(int[] a){
    for(var i=0; i < a.Length; i++){
        Console.Write("{0} ",myList[i]);
    }
    Console.WriteLine();
}
```

The Console.WriteLine() statement is used to check whether we have found the correct minimum value.  The values in **position 0 and position 3** will now be swapped.


| 0 | 1 | 2 | 3 | 4 | 5 | 6 |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| **76** | 10 | 5 | **-17** | 34 | 25 | 2 |

 The C# code to swap the two values is
 
```csharp
swap = myList[0];
myList[0] = myList[minIndex];
myList[minIndex] = swap;

printArray( myList )
```

**Notice** that myList\[0\] must first be saved using another variable so that its value is not **'lost'** during the assignment statement in line 2.  The new list looks like this,

| 0 | 1 | 2 | 3 | 4 | 5 | 6 |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| **-17** | 10 | 5 | **76** | 34 | 25 | 2 |

To sort the remainder of the list, the same algorithm is followed **starting at index 1**, so for the next pass the C# code would be,

```csharp
minIndex = 1;
for(var i=2; i < mylist.Length; i++){ in range( 2, len(myList) ){
    if (myList[i] < myList[minIndex]){
        minIndex = i;
    }
}
Console.WriteLine( myList[minIndex] );

swap = myList[1];
myList[1] = myList[index];
myList[index] = swap;

printArray( myList );
```

The new list looks like this after the second pass through,

| 0 | 1 | 2 | 3 | 4 | 5 | 6 |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| -17 | **2** | 5 | 76 | 34 | 25 | **10** |

We continue to **repeat **these pieces of code from index 2 to 5, where 5 is the second last index of the list.  If you look at the pattern of the index values in the code above, it should be evident that we could simply use a second loop as follows,

```csharp
int swap;
int minIndex;

for(var j=0; i< myList.Length; j++){
    minIndex = j;
    for(var i=j+1; i < myList.Length; i++){
          if (myList[i] < myList[index]){
              minIndex = i;
          }
    swap = myList[j];
    myList[j] = myList[minIndex];
    myList[minIndex] = swap;
    printArray(myList);
}
```

The **print\( myList \)** statement simply shows the list after each pass through.  It can be removed once you are convinced that the code works.

