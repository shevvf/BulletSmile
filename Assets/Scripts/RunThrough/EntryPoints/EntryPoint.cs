using RunThrough.Game.GameStateMachine;
using RunThrough.Game.GameStateMachine.States;

using VContainer.Unity;

namespace RunThrough.EntryPoints
{
    public class EntryPoint : IStartable
    {
        private readonly GameMachine gameMachine;
        public EntryPoint(GameMachine gameMachine)
        {
            this.gameMachine = gameMachine;
        }

        public void Start()
        {
            gameMachine.Enter<GameInit>();
        }
    }
}