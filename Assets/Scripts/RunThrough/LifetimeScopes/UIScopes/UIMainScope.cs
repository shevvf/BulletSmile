using System;

using RunThrough.UI;

using TMPro;

using UnityEngine;

namespace RunThrough.LifetimeScopes.UIScopes
{
    public class UIMainScope : UIScope<UIMainScope.UIView, UIMainPresenter>
    {
        [Serializable]
        public class UIView
        {
            [field: SerializeField] public TMP_Text HealthText { get; private set; }
        }
    }
}