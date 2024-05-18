using RunThrough.Infrastructure.Factories;

namespace RunThrough.Game.GameplayStateMachine.States
{
    public class GameplayInit : IGameplayState
    {
        private readonly GameplayMachine gameplayMachine;
        private readonly GameplayFactory gameplayFactory;

        public GameplayInit(GameplayMachine gameplayMachine, GameplayFactory gameplayFactory)
        {
            this.gameplayMachine = gameplayMachine;
            this.gameplayFactory = gameplayFactory;
        }

        public async void Enter()
        {
            await gameplayFactory.CreateBaseResource();

            gameplayMachine.Enter<GameplayStart>();
        }

        public void Exit()
        {
        }
    }
}
