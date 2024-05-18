using RunThrough.Infrastructure.Factories;
using RunThrough.Level;
using RunThrough.ObjectFolders;
using RunThrough.StaticData.BaseConfigs;

using UnityEngine;

using VContainer;
using VContainer.Unity;

namespace RunThrough.LifetimeScopes.EntityScopes
{
    public class LevelScope : EntityScope<LevelBaseConfig>
    {
        [field: SerializeField] public LevelFolder LevelFolder { get; private set; }

        protected override void Configure(IContainerBuilder builder)
        {
            base.Configure(builder);

            builder.RegisterEntryPoint<LevelEntry>();

            builder.Register<EntityFactory>(Lifetime.Singleton).AsSelf();

            builder.RegisterInstance(LevelFolder);
        }
    }
}