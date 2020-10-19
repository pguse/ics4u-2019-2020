using System;

namespace TestMagicSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] square = {{4,9,2},
                             {3,5,7},
                             {8,1,6}};
            
            Console.WriteLine( max(square) );
            Console.WriteLine( rowSum(square,0) );
            Console.WriteLine( colSum(square,0) );
            Console.WriteLine( isMagicSquare(square) );
        }

        // ADD  CODE BELOW
        static int max(int[,] a)
        {
            return -1;
        }

        static int rowSum(int[,] a, int x)
        {
            return -1;
        }

        static int colSum(int[,] a, int x)
        {
            return -1;
        }

        static bool isMagicSquare(int[,] a)
        {
            return false;
        }
    }
}
