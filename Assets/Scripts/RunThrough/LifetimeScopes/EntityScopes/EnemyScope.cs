using RunThrough.Infrastructure.Services.EnemyService;
using RunThrough.StaticData.BaseConfigs;

using VContainer;
using VContainer.Unity;

namespace RunThrough.LifetimeScopes.EntityScopes
{
    public class EnemyScope : EntityScope<EnemyBaseConfig>
    {
        protected override void Configure(IContainerBuilder builder)
        {
            base.Configure(builder);

            builder.RegisterEntryPoint<EnemyService>();

            builder.Register<EnemyModel>(Lifetime.Singleton).WithParameter(Config).AsImplementedInterfaces();
        }
    }
}