using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using RunThrough.Infrastructure.AbstractStateMachine;
using RunThrough.Infrastructure.AbstractStateMachine.States;

using VContainer;
using VContainer.Unity;

namespace RunThrough.LifetimeScopes.Installers
{
    public class StateMachineInstaller<TMachine, TStates> : IInstaller
        where TMachine : IStateMachine
        where TStates : class, IExitable
    {
        public void Install(IContainerBuilder builder)
        {
            builder.Register<TMachine>(Lifetime.Singleton).AsSelf();

            List<Type> stateTypes = Assembly.GetExecutingAssembly()
                                            .GetTypes()
                                            .Where(type => typeof(TStates).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract)
                                            .ToList();
            stateTypes.ForEach(type => builder.Register(type, Lifetime.Scoped).AsImplementedInterfaces());

            builder.RegisterBuildCallback(container =>
            {
                TMachine stateMachine = container.Resolve<TMachine>();
                IEnumerable<TStates> states = container.Resolve<IEnumerable<TStates>>();
                stateMachine.RegisterStates(states);
            });
        }
    }
}