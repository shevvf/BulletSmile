namespace RunThrough.Game.GameStateMachine.States
{
    public class GameInit : IGameState
    {
        private readonly GameMachine gameMachine;

        public GameInit(GameMachine gameMachine)
        {
            this.gameMachine = gameMachine;
        }

        public void Enter()
        {
            gameMachine.Enter<GameLoadGameplay>();
        }

        public void Exit()
        {
        }
    }
}