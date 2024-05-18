using System;

using RunThrough.UI;

using UnityEngine;
using UnityEngine.UI;

namespace RunThrough.LifetimeScopes.UIScopes
{
    public class UIStartPopUpScope : UIScope<UIStartPopUpScope.UIView, UIStartPopUpPresenter>
    {
        [Serializable]
        public class UIView
        {
            [field: SerializeField] public CanvasGroup FadeablePanel { get; private set; }
            [field: SerializeField] public Button Start { get; private set; }
        }
    }
}