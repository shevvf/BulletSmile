using RunThrough.EntryPoints;

using VContainer;
using VContainer.Unity;

namespace RunThrough.LifetimeScopes
{
    public class BootScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<EntryPoint>();
        }
    }
}