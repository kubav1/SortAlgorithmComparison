namespace SortAlgorithmComparison.Algorithms
{
    internal class QuickSort : SortAlgorithm
    {
        public QuickSort(int n, ArrayType arrayType) : base(n, arrayType) { }

        protected override void SortInternal() => SortArray(data, 0, data.Length - 1);

        public void SortArray(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var mid = array[(leftIndex + rightIndex) / 2];
            do
            {
                while (array[i] < mid) i++;
                while (array[j] > mid) j--;

                if (i <= j)
                {
                    (array[j], array[i]) = (array[i], array[j]);
                    i++;
                    j--;
                }
            } while (i <= j);

            if (j > leftIndex) SortArray(array, leftIndex, j);
            if (i < rightIndex) SortArray(array, i, rightIndex);
        }
    }
}
