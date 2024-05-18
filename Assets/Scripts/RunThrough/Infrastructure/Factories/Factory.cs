using System.Collections.Generic;
using System.IO;

using Cysharp.Threading.Tasks;

using UnityEngine;

namespace RunThrough.Infrastructure.Factories
{
    public class Factory : IFactory
    {
        private readonly List<GameObject> loadedPrefabs = new();

        public async UniTask<GameObject> CreateResource(string prefabPath, Vector3 position, Quaternion rotation, Transform parent = null)
        {
            GameObject prefab = await LoadPrefabAsync(prefabPath);
            return Instantiate(prefab, position, rotation, parent);
        }

        public GameObject Instantiate(GameObject prefab, Vector3 position, Quaternion rotation, Transform parent)
        {
            return Object.Instantiate(prefab, position, rotation, parent);
        }

        private async UniTask<GameObject> LoadPrefabAsync(string path)
        {
            GameObject prefab = loadedPrefabs.Find(p => p.name == Path.GetFileNameWithoutExtension(path));
            if (prefab == null)
            {
                ResourceRequest request = Resources.LoadAsync<GameObject>(path);
                await request;

                prefab = request.asset as GameObject;
                loadedPrefabs.Add(prefab);
            }
            return prefab;
        }

    }
}
