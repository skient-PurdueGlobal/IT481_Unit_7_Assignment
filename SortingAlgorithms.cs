using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace IT481_Unit_7_Assignment
{
    class SortingAlgorithms
    {
        //Variables

        //Constructors
        public SortingAlgorithms() { }

        //Methods
        //Bubble sort from https://medium.com/engineering-hub/https-medium-com-engineering-hub-sorting-algorithms-in-csharp-and-java-4615f6f87696.
        public static TimeSpan BubbleSort(int[] rawArray)
        {
            int[] sortedArr = rawArray.ToArray();

            Stopwatch watch = new Stopwatch();
            watch.Start();

            int n = sortedArr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < (n - i - 1); j++)
                {
                    if (sortedArr[j] > sortedArr[j + 1])
                    {
                        //Swap temp and array[i].
                        int temp = sortedArr[j];

                        sortedArr[j] = sortedArr[j + 1];
                        sortedArr[j + 1] = temp;
                    }
                }
            }

            watch.Stop();

            return watch.Elapsed;
        }

        //Merge sort from IT391 Unit 4 Assignment.
        public static int[] QuickSort(int[] rawArray, int left, int right)
        {
            int[] sortedArr = rawArray.ToArray();

            if (sortedArr != null && sortedArr.Length != 0 && left < right)
            {
                //Pick the Pivot.
                int middle = left + (right - left) / 2;
                int pivot = sortedArr[middle];

                //Make left < pivot and right > pivot.
                int i = left, j = right;
                while (i <= j)
                {
                    while (sortedArr[i] < pivot)
                        i++;
                    while (sortedArr[j] > pivot)
                        j--;
                    if (i <= j)
                    {
                        int temp = sortedArr[i];
                        sortedArr[i] = sortedArr[j];
                        sortedArr[j] = temp;
                        i++;
                        j--;
                    }
                }
                //Recursively sort two sub parts.
                if (left < j)
                    sortedArr = QuickSort(sortedArr, left, j);
                if (right > i)
                    sortedArr = QuickSort(sortedArr, i, right);
            }

            return sortedArr;
        }
    }
}
