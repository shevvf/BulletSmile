using Cysharp.Threading.Tasks;

using UnityEngine;

namespace RunThrough.Infrastructure.Services.FadeService
{
    public interface IFade
    {
        UniTask FadeInAsync(CanvasGroup canvasGroup, float duration, float delay = 0.0f);

        UniTask FadeOutAsync(CanvasGroup canvasGroup, float duration, float delay = 0.0f);
    }
}