namespace Apollo.Counter.Domain
{
    public class Counter
    {
        public Counter(int currentcount)
        {
            CurrentCount = currentcount;
        }

        public int CurrentCount { get; private set; }

        public void IncrementCount() => CurrentCount++;
    }
}