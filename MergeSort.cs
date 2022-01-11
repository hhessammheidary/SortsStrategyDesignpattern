namespace SortWithStrategyDesignP
{
    public class MergeSort<T> : SortWithStrategyDesignPBase<T> where T : IComparable<T>
    {
        public void MergeSrt(List<T> input) //mergesort:
                                            //worst:nlogn , best:nlogn , avg:nlogn
        {
            int len = input.Count;
            if (len < 2)
                return;

            int mid;
            if (len % 2 == 0)
                mid = len / 2;
            else
                mid = len / 2 + 1;

            List<T> temp1 = new List<T>();
            List<T> temp2 = new List<T>();
            for (int i = 0; i < mid; i++)
            {
                temp1.Add(input[i]);
            }
            for (int i = mid; i < len; i++)
            {
                temp2.Add(input[i]);
            }
            MergeSrt(temp1);
            MergeSrt(temp2);

            int left = 0;
            int right = 0;
            int ctr = 0;
            while (left < temp1.Count && right < temp2.Count)
            {
                if (temp1[left].CompareTo(temp2[right]) == 0 || temp1[left].CompareTo(temp2[right]) < 0)
                    input[ctr++] = temp1[left++];

                else
                    input[ctr++] = temp2[right++];

            }
            while (left < temp1.Count)
            {
                input[ctr++] = temp1[left++];
            }
            while (right < temp2.Count)
            {
                input[ctr++] = temp2[right++];
            }

        }

        public override void Sort(List<T> input)
        {
            MergeSrt(input);
        }
    }
}
