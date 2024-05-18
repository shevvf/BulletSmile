using VContainer.Unity;

namespace RunThrough.UI
{
    public interface IUIPresenter : IStartable
    {
        void InitializeView();

        void InitializeModel();
    }
}