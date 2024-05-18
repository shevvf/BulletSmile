using System;

using Cysharp.Threading.Tasks;

using UnityEngine;
using UnityEngine.SceneManagement;

namespace RunThrough.Infrastructure.Services.SceneLoaderService
{
    public class SceneLoaderService : ISceneLoader
    {
        public async UniTask LoadAsync(object sceneIdOrName, Action OnLoaded = null)
        {
            await LoadSceneAsync(sceneIdOrName, OnLoaded);
        }

        private async UniTask LoadSceneAsync(object sceneIdOrName, Action OnLoaded = null)
        {
            AsyncOperation waitNextScene = sceneIdOrName is int sceneId
                 ? SceneManager.LoadSceneAsync(sceneId)
                 : SceneManager.LoadSceneAsync(sceneIdOrName.ToString());

            await waitNextScene;

            OnLoaded?.Invoke();
        }
    }
}