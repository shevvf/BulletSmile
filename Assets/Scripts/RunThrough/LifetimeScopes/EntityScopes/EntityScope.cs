using UnityEngine;

using VContainer;
using VContainer.Unity;

namespace RunThrough.LifetimeScopes.EntityScopes
{
    public class EntityScope<TConfig> : LifetimeScope
    where TConfig : ScriptableObject
    {
        [field: SerializeField] public TConfig Config { get; private set; }

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterInstance(Config);
        }
    }
}