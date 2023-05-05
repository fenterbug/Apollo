namespace Apollo.Counter.Domain
{
	public interface ICounterRepository
	{
		Counter GetCounter();
		void UpdateCounter(Counter counter);
	}
}