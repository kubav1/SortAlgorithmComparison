namespace SortAlgorithmComparison.Algorithms
{
    internal class SelectionSort : SortAlgorithm
    {
        public SelectionSort(int n, ArrayType arrayType) : base(n, arrayType) { }

        protected override void SortInternal()
        {
            for (var i = 0; i < data.Length - 1; i++)
            {
                var smallestVal = i;
                for (var j = i + 1; j < data.Length; j++)
                    if (data[j] < data[smallestVal]) smallestVal = j;
                (data[i], data[smallestVal]) = (data[smallestVal], data[i]);
            }
        }
    }
}
