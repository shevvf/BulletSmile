using R3;

namespace RunThrough.PlayerController
{
    public interface IWin
    {
        Subject<Unit> OnWinSubject { get; }

        Observable<Unit> OnWin { get; }
    }
}