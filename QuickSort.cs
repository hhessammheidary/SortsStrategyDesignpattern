namespace SortWithStrategyDesignP
{
    public class QuickSort<T> : SortWithStrategyDesignPBase<T> where T : IComparable
    {
        public int Partition(List<T> input, int s, int e)//quicksort:
                                                         //avg:nlong , worst:n^2 , best:nlogn
        {
            T temp;
            T x = input[s];
            int i = s;
            for (int j = s + 1; j <= e; j++)
            {
                if (input[j].CompareTo(x) < 0 || input[j].CompareTo(x) == 0)
                {
                    i++;
                    temp = input[j];
                    input[j] = input[i];
                    input[i] = temp;
                }
            }
            temp = input[i];
            input[i] = input[s];
            input[s] = temp;
            return i;
        }
        public void QuickSrt(List<T> input, int s, int e)
        {
            int partition;
            if (s < e)
            {
                partition = Partition(input, s, e);
                QuickSrt(input, s, partition- 1);
                QuickSrt(input, partition + 1, e);
            }
        }

        void DoQuickSrt(List<T> input)
        {
            QuickSrt(input, 0, input.Count - 1);
        }
        public override void Sort(List<T> input)
        {
            DoQuickSrt(input);
        }
    }
}
