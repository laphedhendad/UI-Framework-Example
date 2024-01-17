using Laphed.Rx;

namespace Example
{
    public interface IBooster
    {
        IReactiveProperty<int> Amount { get; }
    }
}