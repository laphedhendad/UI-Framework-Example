using Laphed.Rx;

namespace Example
{
    public class Booster: IBooster
    {
        public IReactiveProperty<int> Amount { get; } = new ReactiveProperty<int>();
    }
}