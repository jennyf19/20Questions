using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortReal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 5, 9, 2, 14, 24, 10, 7, 19, 27, 18 };            
            int low = 0;
            int high = 11;

            PrintMyArray(myArray, low, high);

            QuickSort(myArray, 0, 11);

            PrintMyArray(myArray, low, high);

            Console.ReadLine();
        }

        //        algorithm quicksort(A, lo, hi) is
        //if lo < hi then
        //    p := partition(A, lo, hi)
        //    quicksort(A, lo, p – 1)
        //    quicksort(A, p + 1, hi)
        static void QuickSort(int[] myArray, int low, int high)
        {
         if (low < high)
            {
                int p = Partition(myArray, low, high);
                QuickSort(myArray, low, p - 1);
                QuickSort(myArray, p + 1, high);
            }
        }
    //    algorithm partition(A, lo, hi) is
    //pivot := A[hi]
    //i := lo        // place for swapping
    //for j := lo to hi – 1 do
    //    if A[j] ≤ pivot then
    //        swap A[i] with A[j]
    //        i := i + 1
    //swap A[i] with A[hi]
    //return i
        static int Partition(int[] myArray, int low, int high)
        {
            int pivot = myArray[high];
            int i = low;
            for (int j = low; j <= high - 1; j++)
            {
                if (myArray[j] <= pivot)
                {
                    int temp = myArray[i];
                    myArray[i] = myArray[j];
                    myArray[j] = temp;
                    i = i + 1;
                }
                
            }
            int temp2 = myArray[i];
            myArray[i] = myArray[high];
            myArray[high] = temp2;
            return i;

        }
        static void PrintMyArray(int[] myArray, int low, int high)
        {
            for (int i = low; i <= high; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
   }


}
