using RunThrough.PlayerController;

using VContainer;
using VContainer.Unity;

public class PlayerScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterEntryPoint<PlayerService>();

        builder.Register<Player>(Lifetime.Singleton).AsImplementedInterfaces();
        builder.Register<PlayerStates>(Lifetime.Singleton).AsImplementedInterfaces();
    }
}