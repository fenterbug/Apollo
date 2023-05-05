using Apollo.Counter.Domain;

namespace Apollo.Persistence.InMemory
{
    public class CounterRepository : ICounterRepository
    {
        private int currentcount;

        public CounterRepository()
        {
            currentcount = 0;
        }

        public Counter.Domain.Counter GetCounter()
        {
            return new Counter.Domain.Counter(currentcount);
        }

        public void UpdateCounter(Counter.Domain.Counter counter)
        {
            currentcount = counter.CurrentCount;
        }
    }
}