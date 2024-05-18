using RunThrough.Infrastructure.AssetsManagement.AssetsPath;
using RunThrough.Infrastructure.Factories;
using RunThrough.ObjectFolders;

using UnityEngine;

namespace RunThrough.Game.GameplayStateMachine.States
{
    public class GameplayLose : IGameplayState
    {
        private readonly MainFolder mainFolder;
        private readonly IFactory factory;

        public GameplayLose(MainFolder mainFolder, IFactory factory)
        {
            this.mainFolder = mainFolder;
            this.factory = factory;
        }

        public async void Enter()
        {
            await factory.CreateResource(UIPath.LOSE_POPUP_PATH, mainFolder.UIFolder.UIPopUpHolder.position, Quaternion.identity, mainFolder.UIFolder.UIPopUpHolder);
        }

        public void Exit()
        {

        }
    }
}