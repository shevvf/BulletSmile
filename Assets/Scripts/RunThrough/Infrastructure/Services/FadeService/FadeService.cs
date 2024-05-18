using Cysharp.Threading.Tasks;

using DG.Tweening;

using UnityEngine;

namespace RunThrough.Infrastructure.Services.FadeService
{
    public class FadeService : IFade
    {
        private const float MIN_ALPHA = 0.0f;
        private const float MAX_ALPHA = 1.0f;

        private const Ease EASE = Ease.Linear;

        public async UniTask FadeOutAsync(CanvasGroup canvasGroup, float duration, float delay = 0.0f)
        {
            canvasGroup.interactable = false;
            canvasGroup.alpha = MAX_ALPHA;

            await DOTween.To(() => canvasGroup.alpha, x => canvasGroup.alpha = x, MIN_ALPHA, duration)
                .SetDelay(delay)
                .SetEase(EASE)
                .SetUpdate(true)
                .AsyncWaitForCompletion();
        }

        public async UniTask FadeInAsync(CanvasGroup canvasGroup, float duration, float delay = 0.0f)
        {
            canvasGroup.alpha = MIN_ALPHA;

            await DOTween.To(() => canvasGroup.alpha, x => canvasGroup.alpha = x, MAX_ALPHA, duration)
                .SetDelay(delay)
                .SetEase(EASE)
                .SetUpdate(true)
                .AsyncWaitForCompletion();

            canvasGroup.interactable = true;
        }
    }
}