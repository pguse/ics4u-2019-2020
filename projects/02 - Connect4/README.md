# Project: Connect 4

This project demonstrates how you might use a **two-dimensional** array in C# to store information in a grid-based game like ***Connect 4*** .  In this case a 6 x 7 two-dimensional array ***(6 rows, 7 columns)*** is used to store the 42 possible positions of the Connect 4 game.  The players of the game indicate which column they would like to play in using the following numbering system.

|   |   |   |   |   |   |   |
| :-------------: | :-------------: | :-------------: | :-------------: | :-------------: | :-------------: | :-------------: |
| 1 | 2 | 3 | 4 | 5 | 6 | 7 |

For information about the game Connect 4 click [here](https://en.wikipedia.org/wiki/Connect_Four).

## Note:  Using Multi-Dimensional Arrays in C#

Click [here](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays) to get more detailed information about how to use multi-dimensional arrays in C#.

# Task:

At the moment this project will detect a **Win!** in the ***bottom row*** only and end the game by declaring the winner.  However, there are 6 rows to deal with in Connect 4.  Your task is to,

1.  Modify the **GameOver()** function so that it detects a win in ***all six rows*** .
2.  Modify the **GameOver()** function so that it detects a win in ***all seven columns*** .  **Suggestion:**  ***Try to detect all possible wins in the first column.***  Once you have tested your program and it works for the first column, extend it so that it works for all columns.
3.  Modify the **GameOver()** function so that it detects a win along ***a diagonal that goes up to the right*** .  **Suggestion:**  ***Try to detect all possible wins along a diagonal that starts on the bottom row.***  Once you have tested your program and it works for these situations, extend it so that it works for all diagonals that go up to the right.
4.  Modify the **GameOver()** function so that it detects a win along ***a diagonal that goes down to the right*** .  **Suggestion:**  ***Try to detect all possible wins along a diagonal that ends on the bottom row.***  Once you have tested your program and it works for these situations, extend it so that it works for all diagonals that go down to the right.
5.  Complete the **GameOver()** function by adding code that will detect a tie, end the game, and declare the **Tie!**.
