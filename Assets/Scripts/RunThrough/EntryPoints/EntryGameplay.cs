using RunThrough.Game.GameplayStateMachine;
using RunThrough.Game.GameplayStateMachine.States;

using VContainer.Unity;

namespace RunThrough.EntryPoints
{
    public class EntryGameplay : IStartable
    {
        private readonly GameplayMachine gameplayMachine;

        public EntryGameplay(GameplayMachine gameplayMachine)
        {
            this.gameplayMachine = gameplayMachine;
        }

        public void Start()
        {
            gameplayMachine.Enter<GameplayInit>();
        }
    }
}