namespace SortWithStrategyDesignP
{
    public abstract class SortWithStrategyDesignPBase<T>
    {
        public abstract void Sort(List<T> input);
        //Refactor => List , Generic type, String 
        //public abstract List<int> Sort(List<int> items);
    }
}
