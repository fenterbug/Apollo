namespace Apollo.Counter.Domain
{
    public partial interface IContext
    {
        ICounterRepository CounterRepository { get; }
    }
}