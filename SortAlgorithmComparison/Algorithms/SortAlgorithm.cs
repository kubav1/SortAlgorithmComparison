using System;

namespace SortAlgorithmComparison.Algorithms
{
    public enum SortAlgorithmType
    {
        BubbleSort,
        QuickSort,
        MergeSort,
        InsertionSort,
        SelectionSort
    }

    public enum ArrayType
    {
        Random,
        Ascending,
        Descending
    }

    internal abstract class SortAlgorithm
    {
        private readonly Random random = new Random();
        protected readonly int[] data;
        protected DateTime start, stop;

        public Double Duration => start != null && stop != null ? (stop - start).TotalMilliseconds : 0;

        public SortAlgorithm(int n, ArrayType arrayType)
        {
            data = new int[n];
            switch (arrayType)
            {
                case ArrayType.Random:
                    for (var i = 0; i < n; i++) data[i] = random.Next();
                    break;
                case ArrayType.Ascending:
                    for (var i = 0; i < n; i++) data[i] = i;
                    break;
                case ArrayType.Descending:
                    for (var i = 0; i < n; i++) data[i] = n - i;
                    break;
            }
        }

        public void Sort() 
        {
            start = DateTime.Now;
            SortInternal();
            stop = DateTime.Now;
        }

        protected virtual void SortInternal() { }
    }
}
