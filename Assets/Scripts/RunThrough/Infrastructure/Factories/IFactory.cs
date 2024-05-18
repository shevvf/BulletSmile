using Cysharp.Threading.Tasks;

using UnityEngine;

namespace RunThrough.Infrastructure.Factories
{
    public interface IFactory
    {
        UniTask<GameObject> CreateResource(string prefabPath, Vector3 position, Quaternion rotation, Transform parent = null);

        GameObject Instantiate(GameObject prefab, Vector3 position, Quaternion rotation, Transform parent);
    }
}