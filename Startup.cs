using SortWithStrategyDesignP;

namespace MaSortWithStrategyDesignPin
{
    public class Startup
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int> { 10 ,10 ,10 ,6 , 5 , 4 ,3 , 2 ,1 ,100 ,100 ,100 };
            SortWithStrategyDesignPBase<int> merge = new MergeSort<int>();
            merge.Sort(input);
            foreach (int i in input)
            {
                Console.WriteLine(i);
            }
        }

    }
}
