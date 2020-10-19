using System;

namespace TestConwayGameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] world = {0,1,1,0,0,1,0,1};
            int[] future = new int[8];

            // ADD CODE HERE

            // Copies future array contents to world array
            Array.Copy(future,world,future.Length);
            // Output new world array
            print(world);
        }

        static void print(int[] a)
        {
            for(var i=0; i < a.Length; i++){
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
