using R3;

namespace RunThrough.PlayerController
{
    public interface ILose
    {
        Subject<Unit> OnLoseSubject { get; }

        Observable<Unit> OnLose { get; }
    }
}