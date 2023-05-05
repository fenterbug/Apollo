using Apollo.Counter.Domain;

namespace Apollo.Persistence.InMemory
{
    public class InMemoryContext : IContext
    {
        private CounterRepository counters = new();
        ICounterRepository IContext.CounterRepository => counters;
    }
}