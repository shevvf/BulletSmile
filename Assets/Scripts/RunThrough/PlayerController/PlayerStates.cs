using R3;

namespace RunThrough.PlayerController
{
    public class PlayerStates : IPlayerStates
    {
        public Subject<Unit> OnWinSubject => new();
        public Subject<Unit> OnLoseSubject => new();

        public Observable<Unit> OnWin => OnWinSubject.Share();
        public Observable<Unit> OnLose => OnLoseSubject.Share();
    }
}