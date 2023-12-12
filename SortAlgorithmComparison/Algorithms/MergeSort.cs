﻿namespace SortAlgorithmComparison.Algorithms
{
    internal class MergeSort : SortAlgorithm
    {
        public MergeSort(int n, ArrayType arrayType) : base(n, arrayType) { }

        protected override void SortInternal() => SortArray(data, 0, data.Length - 1);

        public void SortArray(int[] array, int left, int right)
        {
            if (left >= right) return;
            var middle = (left + right) / 2;
            SortArray(array, left, middle);
            SortArray(array, middle + 1, right);
            MergeArray(array, left, middle, right);
        }

        public void MergeArray(int[] array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;
            for (i = 0; i < leftArrayLength; ++i) leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j) rightTempArray[j] = array[middle + 1 + j];
            i = 0;
            j = 0;
            int k = left;
            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j]) array[k++] = leftTempArray[i++];
                else array[k++] = rightTempArray[j++];
            }
            while (i < leftArrayLength) array[k++] = leftTempArray[i++];
            while (j < rightArrayLength) array[k++] = rightTempArray[j++];
        }
    }
}
