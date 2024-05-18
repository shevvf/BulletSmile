using RunThrough.EntryPoints;
using RunThrough.Game.GameplayStateMachine;
using RunThrough.Game.GameplayStateMachine.States;
using RunThrough.Infrastructure.Factories;
using RunThrough.Infrastructure.Services.CameraService;
using RunThrough.Infrastructure.Services.FadeService;
using RunThrough.Infrastructure.Services.TimeService;
using RunThrough.LifetimeScopes.Installers;
using RunThrough.ObjectFolders;
using RunThrough.PlayerController;

using UnityEngine;

using VContainer;
using VContainer.Unity;


namespace RunThrough.LifetimeScopes
{
    public class GameplayScope : LifetimeScope
    {
        [field: SerializeField] public MainFolder MainFolder { get; private set; }

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<EntryGameplay>(Lifetime.Singleton);

            builder.Register<GameplayFactory>(Lifetime.Singleton).AsImplementedInterfaces().AsSelf();

            builder.Register<PlayerModel>(Lifetime.Singleton).AsImplementedInterfaces();
            builder.Register<FadeService>(Lifetime.Singleton).AsImplementedInterfaces();
            builder.Register<TimeService>(Lifetime.Singleton).AsImplementedInterfaces();
            builder.Register<CameraService>(Lifetime.Singleton).AsImplementedInterfaces();

            builder.RegisterInstance(MainFolder);

            new StateMachineInstaller<GameplayMachine, IGameplayState>().Install(builder);
        }
    }
}