using RunThrough.UI;

using UnityEngine;

using VContainer;
using VContainer.Unity;

namespace RunThrough.LifetimeScopes.UIScopes
{
    public class UIScope<TUIView, TUIPresenter> : LifetimeScope
    where TUIView : new()
    where TUIPresenter : class, IUIPresenter
    {
        [field: SerializeField] public TUIView View { get; private set; }

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<TUIPresenter>();

            builder.RegisterInstance(View);
        }
    }
}