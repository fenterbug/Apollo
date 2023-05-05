namespace Apollo.Persistence
{
	internal static class CounterConverter
	{
		public static Apollo.Counter.Domain.Counter ToDomainClass(this Pcounter me)
		{
			return Apollo.Counter.Domain.Counter.Reconstitute(me.Value);
		}

		public static Pcounter FromDomainClass(this Apollo.Counter.Domain.Counter me)
		{
			return new Pcounter(me.CurrentCount);
		}
	}
}