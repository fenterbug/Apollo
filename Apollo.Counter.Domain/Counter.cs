namespace Apollo.Counter.Domain
{
    public class Counter
    {
        public int CurrentCount { get; private set; }

        public void IncrementCount() => CurrentCount++;
    }
}