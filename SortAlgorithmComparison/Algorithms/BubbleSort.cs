namespace SortAlgorithmComparison.Algorithms
{
    internal class BubbleSort : SortAlgorithm
    {
        public BubbleSort(int n, ArrayType arrayType) : base(n, arrayType) { }

        protected override void SortInternal()
        {
            for (var i = 0; i < data.Length; i++)
                for (var j = 0; j < data.Length; j++)
                    if (data[i] > data[j]) (data[j], data[i]) = (data[i], data[j]);
        }
    }
}
