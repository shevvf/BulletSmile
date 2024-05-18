using Cysharp.Threading.Tasks;

using RunThrough.Infrastructure.AssetsManagement.AssetsPath;
using RunThrough.Infrastructure.Factories;
using RunThrough.LifetimeScopes.EntityScopes;
using RunThrough.ObjectFolders;
using RunThrough.StaticData.BaseConfigs;

using UnityEngine;

using VContainer.Unity;

namespace RunThrough.Level
{
    public class LevelEntry : VObject<LevelScope>, IStartable
    {
        private readonly LevelFolder levelFolder;
        private readonly EntityFactory entityFactory;
        private readonly LevelBaseConfig levelBaseConfig;

        public LevelEntry(LevelFolder levelFolder, EntityFactory entityFactory, LevelBaseConfig levelBaseConfig)
        {
            this.levelFolder = levelFolder;
            this.entityFactory = entityFactory;
            this.levelBaseConfig = levelBaseConfig;
        }

        async void IStartable.Start()
        {
            await CreateLevelEntities();
        }

        private async UniTask CreateLevelEntities()
        {
            await entityFactory.CreatePlayer(EntityPath.PLAYER_ENTITY_PATH, levelFolder.PlayerFolder.PlayerInitPosition.position, Quaternion.identity, levelFolder.PlayerFolder.PlayerInitPosition);

            for (int i = 0; i < levelBaseConfig.EnemyPrefabs.Count; i++)
            {
                await entityFactory.CreateEnemy(levelBaseConfig.EnemyPrefabs[i], levelFolder.EnemyFolder.EnemyInitPositions[i].position, levelFolder.EnemyFolder.EnemyInitPositions[i].rotation, levelFolder.EnemyFolder.EnemyInitPositions[i]);
            }
        }
    }
}