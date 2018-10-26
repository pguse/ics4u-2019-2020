using System;

namespace SortingSelSort
{
    class Program
    {
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
    }
}
