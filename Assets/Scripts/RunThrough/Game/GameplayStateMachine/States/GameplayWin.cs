using RunThrough.Infrastructure.AssetsManagement.AssetsPath;
using RunThrough.Infrastructure.Factories;
using RunThrough.ObjectFolders;

using UnityEngine;

namespace RunThrough.Game.GameplayStateMachine.States
{
    public class GameplayWin : IGameplayState
    {
        private readonly MainFolder mainFolder;
        private readonly IFactory factory;

        public GameplayWin(MainFolder mainFolder, IFactory factory)
        {
            this.mainFolder = mainFolder;
            this.factory = factory;
        }

        public async void Enter()
        {
            await factory.CreateResource($"{UIPath.WIN_POPUP_PATH}", mainFolder.UIFolder.UIPopUpHolder.position, Quaternion.identity, mainFolder.UIFolder.UIPopUpHolder);
            Debug.Log("WIN_POPUP Created");
        }

        public void Exit()
        {
        }
    }
}
