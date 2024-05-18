using R3;

using RunThrough.Game.GameplayStateMachine;
using RunThrough.Game.GameplayStateMachine.States;

namespace RunThrough.PlayerController
{
    public class Player : VObject<PlayerScope>, IPlayer
    {
        private readonly GameplayMachine gameplayMachine;
        private readonly IPlayerStates playerStates;

        public Player(GameplayMachine gameplayMachine, IPlayerStates playerStates)
        {
            this.gameplayMachine = gameplayMachine;
            this.playerStates = playerStates;
        }

        public void Initialize()
        {
            playerStates.OnWin.Subscribe(_ =>
            {
                Win();

            }).AddTo(Scope);

            playerStates.OnLose.Subscribe(_ =>
            {
                Lose();

            }).AddTo(Scope);
        }

        public void Dispose()
        {

        }

        private void Win()
        {
            gameplayMachine.Enter<GameplayWin>();
        }

        private void Lose()
        {
            gameplayMachine.Enter<GameplayLose>();
        }
    }
}