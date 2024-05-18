using VContainer;
using VContainer.Unity;

public class VObject<T> where T : LifetimeScope
{
    [Inject] protected LifetimeScope LifetimeScope { private get; set; }

    protected T Scope => LifetimeScope as T;

}
