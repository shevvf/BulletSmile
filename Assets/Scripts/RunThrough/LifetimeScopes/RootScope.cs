using RunThrough.Game.GameStateMachine;
using RunThrough.Game.GameStateMachine.States;
using RunThrough.Infrastructure.Services.InputService;
using RunThrough.Infrastructure.Services.SceneLoaderService;
using RunThrough.LifetimeScopes.Installers;
using RunThrough.StaticData.BaseConfigs;

using UnityEngine;
using UnityEngine.InputSystem;

using VContainer;
using VContainer.Unity;

namespace RunThrough.LifetimeScopes
{
    public class RootScope : LifetimeScope
    {
        [field: SerializeField] public PlayerBaseConfig PlayerBaseConfig { get; private set; }
        [field: SerializeField] public InputActionReference InputActionReference { get; private set; }

        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<SceneLoaderService>(Lifetime.Singleton).AsImplementedInterfaces();
            builder.Register<InputService>(Lifetime.Singleton).AsImplementedInterfaces();

            builder.RegisterInstance(PlayerBaseConfig);
            builder.RegisterInstance(InputActionReference);

            new StateMachineInstaller<GameMachine, IGameState>().Install(builder);
        }
    }
}