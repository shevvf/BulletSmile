using R3;

namespace RunThrough.PlayerController
{
    public interface IPlayerModel
    {
        ReactiveProperty<int> CurrentHealth { get; set; }
    }
}