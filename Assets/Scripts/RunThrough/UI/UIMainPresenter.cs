using Framework.Extensions;

using R3;

using RunThrough.LifetimeScopes.UIScopes;
using RunThrough.PlayerController;

using VContainer.Unity;

namespace RunThrough.UI
{
    public class UIMainPresenter : VObject<UIMainScope>, IUIPresenter
    {
        private readonly UIMainScope.UIView uIView;
        private readonly IPlayerModel playerModel;

        public UIMainPresenter(UIMainScope.UIView uIView, IPlayerModel playerModel)
        {
            this.uIView = uIView;
            this.playerModel = playerModel;
        }

        void IStartable.Start()
        {
            InitializeModel();
            InitializeView();
        }

        public void InitializeModel()
        {
            playerModel.CurrentHealth.SubscribeToTMPText(uIView.HealthText).AddTo(Scope);
        }

        public void InitializeView()
        {
        }
    }
}