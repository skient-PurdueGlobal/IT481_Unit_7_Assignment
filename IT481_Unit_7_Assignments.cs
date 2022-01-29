using System;
using System.Diagnostics;
using System.Threading;

namespace IT481_Unit_7_Assignment
{
    class IT481_Unit_7_Assignments
    {
        static void Main(string[] args)
        {
            #region Define test sets.
            int[] smallSet = Array_Generator(100);
            int[] mediumSet = Array_Generator(1000);
            int[] largeSet = Array_Generator(10000);
            #endregion

            #region Test first sort algorithm with all data sets.
            //Small test set.
            TimeSpan smTestOneSpan = SortingAlgorithms.BubbleSort(smallSet);

            //Medium test set.
            TimeSpan mdTestOneSpan = SortingAlgorithms.BubbleSort(mediumSet);

            //Large test set.
            TimeSpan lgTestOneSpan = SortingAlgorithms.BubbleSort(largeSet);
            #endregion

            #region Test second sort algorithm with all data sets.
            //Small test set.
            Stopwatch smWatch = new Stopwatch();
            smWatch.Start();
            int[] smSortedArr = SortingAlgorithms.QuickSort(smallSet, 0, smallSet.Length - 1);
            smWatch.Stop();
            TimeSpan smTestTwoSpan = smWatch.Elapsed;

            //Medium test set.
            Stopwatch mdWatch = new Stopwatch();
            mdWatch.Start();
            int[] mdSortedArr = SortingAlgorithms.QuickSort(mediumSet, 0, mediumSet.Length - 1);
            mdWatch.Stop();
            TimeSpan mdTestTwoSpan = mdWatch.Elapsed;

            //Large test set.
            Stopwatch lgWatch = new Stopwatch();
            lgWatch.Start();
            int[] lgSortedArr = SortingAlgorithms.QuickSort(largeSet, 0, largeSet.Length - 1);
            lgWatch.Stop();
            TimeSpan lgTestTwoSpan = lgWatch.Elapsed;
            #endregion

            //Output of Results.
            Console.WriteLine();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*********************** Unit 7 Assignment Test Results ***********************");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine();
            Console.WriteLine("                          Test #1 - Bubble Sort    Test #2 - Quick Sort");
            Console.WriteLine("Small Data Set (100):           " + String.Format("{0:0.0000}", smTestOneSpan.TotalMilliseconds) + "ms                 " + String.Format("{0:0.0000}", smTestTwoSpan.TotalMilliseconds) + "ms");
            Console.WriteLine("Medium Data Set (2500):         " + String.Format("{0:0.0000}", mdTestOneSpan.TotalMilliseconds) + "ms                 " + String.Format("{0:0.0000}", mdTestTwoSpan.TotalMilliseconds) + "ms");
            Console.WriteLine("Large Data Set (10000):       " + String.Format("{0:0.0000}", lgTestOneSpan.TotalMilliseconds) + "ms                " + String.Format("{0:0.0000}", lgTestTwoSpan.TotalMilliseconds) + "ms");

            //Open console to view results.
            Console.Read();

        }

        //Random array generator method.
        public static int[] Array_Generator(int size)
        {
            int[] array = new int[size];
            Random sNum = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = sNum.Next(1, size + 1);
            }

            return array;
        }
    }
}
