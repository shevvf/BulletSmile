using RunThrough.Infrastructure.AssetsManagement.AssetsPath;

using RunThrough.Infrastructure.Services.SceneLoaderService;

namespace RunThrough.Game.GameStateMachine.States
{
    public class GameLoadGameplay : IGameState
    {
        private readonly ISceneLoader sceneLoader;

        public GameLoadGameplay(ISceneLoader sceneLoader)
        {
            this.sceneLoader = sceneLoader;
        }

        public async void Enter()
        {
            await sceneLoader.LoadAsync(ScenePath.GAMEPLAY_SCENE_NAME);
        }

        public void Exit()
        {
        }
    }
}