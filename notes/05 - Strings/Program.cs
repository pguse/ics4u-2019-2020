using System;

namespace SortingSelSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] {76,25,5,-17,34,10,2};
            var words = new string[] {"orange","kiwi","apple","banana","raspberry","avocado","pear"};
            selSort(nums);
            selSort(words);
            printArray(nums);
            printArray(words);
        }
        
        static void selSort(int[] a)
        {
            int minIndex;
            int swap;
    
            for(var j=0; j < a.Length; j++){
                minIndex = j;
                for(var i=j+1; i < a.Length; i++){
                    if (a[i] < a[minIndex]){
                        minIndex = i;
                    }
                }
        
                swap = a[j];
                a[j] = a[minIndex];
                a[minIndex] = swap;
            }
        }

        static void selSort(string[] a)
        {
            int minIndex;
            string swap;
            int compare;
    
            for(var j=0; j < a.Length; j++){
                minIndex = j;
                for(var i=j+1; i < a.Length; i++){
                    compare = a[i].CompareTo(a[minIndex]);
                    if (compare < 0){
                        minIndex = i;
                    }
                }
        
                swap = a[j];
                a[j] = a[minIndex];
                a[minIndex] = swap;
            }
        }
        static void printArray(int[] a){
            for(var i=0; i < a.Length; i++){
                Console.Write("{0} ",a[i]);
            }
            Console.WriteLine();
        }

        static void printArray(string[] a){
            for(var i=0; i < a.Length; i++){
                Console.Write("{0} ",a[i]);
            }
            Console.WriteLine();
        }

    }
}