using System;

namespace StudentAverageArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var marks = new int[3]; // Declare Array with 3 elements

            marks[0] = 75;
            marks[1] = 80;
            marks[2] = 90;
            
            var mean = (float)(marks[0] + marks[1] + marks[2]) / 3;

            Console.WriteLine("Your average is: {0:0.000}", mean);
        }
    }
}
