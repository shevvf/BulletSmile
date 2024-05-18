using System;

using Cysharp.Threading.Tasks;

namespace RunThrough.Infrastructure.Services.SceneLoaderService
{
    public interface ISceneLoader
    {
        UniTask LoadAsync(object sceneId, Action OnLoaded = null);
    }
}