using Apollo.Counter.Domain;

namespace Apollo.Persistence
{
	public class CounterRepository : ICounterRepository
	{
		public static CounterRepository Instance { get; private set; }

		private Apollo.Persistence.Pcounter pCounter { get; set; }

		static CounterRepository()
		{
			Instance = new CounterRepository();
		}

		public CounterRepository()
		{
			pCounter = new Pcounter();
		}

		Apollo.Counter.Domain.Counter ICounterRepository.GetCounter()
		{
			return pCounter.ToDomainClass();
		}

		public void UpdateCounter(Apollo.Counter.Domain.Counter counter)
		{
			this.pCounter.Value = counter.CurrentCount;
		}
	}
}