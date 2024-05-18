using Cysharp.Threading.Tasks;

using UnityEngine;

namespace RunThrough.Infrastructure.Factories
{
    public class EntityFactory : Factory
    {
        public async UniTask<GameObject> CreatePlayer(string playerPath, Vector3 playerPosition, Quaternion playerRotation, Transform parent = null)
        {
            GameObject level = await CreateResource(playerPath, playerPosition, playerRotation, parent);

            return level;
        }

        public async UniTask<GameObject> CreateEnemy(GameObject enemyPrefab, Vector3 levelPosition, Quaternion levelRotation, Transform parent = null)
        {
            GameObject enemy = Instantiate(enemyPrefab, levelPosition, levelRotation, parent);

            return await UniTask.FromResult(enemy);
        }
    }
}