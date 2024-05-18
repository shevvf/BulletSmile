using System;

using RunThrough.UI;

using UnityEngine;
using UnityEngine.UI;

namespace RunThrough.LifetimeScopes.UIScopes
{
    public class UIEndPopUpScope : UIScope<UIEndPopUpScope.UIView, UIEndPopUpPresenter>
    {
        [Serializable]
        public class UIView
        {
            [field: SerializeField] public CanvasGroup FadeableButton { get; private set; }
            [field: SerializeField] public Button Restart { get; private set; }
        }
    }
}