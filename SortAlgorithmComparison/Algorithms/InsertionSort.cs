namespace SortAlgorithmComparison.Algorithms
{
    internal class InsertionSort : SortAlgorithm
    {
        public InsertionSort(int n, ArrayType arrayType) : base(n, arrayType) { }

        protected override void SortInternal()
        {
            for (var i = 1; i < data.Length; i++)
            {
                var key = data[i];
                var flag = 0;
                for (var j = i - 1; j >= 0 && flag != 1;)
                {
                    if (key < data[j])
                    {
                        data[j + 1] = data[j];
                        j--;
                        data[j + 1] = key;
                    }
                    else flag = 1;
                }
            }
        }
    }
}
