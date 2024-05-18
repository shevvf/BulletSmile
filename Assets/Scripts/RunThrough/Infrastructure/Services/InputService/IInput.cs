using R3;

namespace RunThrough.Infrastructure.Services.InputService
{
    public interface IInput
    {
        ReadOnlyReactiveProperty<bool> IsMousePressed { get; }
    }
}