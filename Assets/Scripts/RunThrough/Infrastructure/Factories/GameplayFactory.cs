using Cysharp.Threading.Tasks;

using RunThrough.Infrastructure.AssetsManagement.AssetsPath;
using RunThrough.ObjectFolders;

using UnityEngine;

namespace RunThrough.Infrastructure.Factories
{
    public class GameplayFactory : Factory
    {
        private readonly MainFolder mainFolder;

        public GameplayFactory(MainFolder mainFolder)
        {
            this.mainFolder = mainFolder;
        }

        public async UniTask CreateBaseResource()
        {
            await CreateResource($"{LevelPath.LEVEL_1}", mainFolder.LevelInitPosition.position, mainFolder.LevelInitPosition.localRotation, mainFolder.LevelInitPosition);
            Debug.Log("LEVEL Created");

            await CreateResource(UIPath.GAMEPLAY_UI_PATH, mainFolder.UIFolder.UIMainHolder.position, Quaternion.identity, mainFolder.UIFolder.UIMainHolder);
            Debug.Log("GAMEPLAY_UI Created");
        }
    }
}