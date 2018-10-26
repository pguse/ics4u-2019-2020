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
