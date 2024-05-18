using R3;

using RunThrough.Game.GameplayStateMachine;
using RunThrough.Game.GameplayStateMachine.States;
using RunThrough.Infrastructure.Services.FadeService;
using RunThrough.LifetimeScopes.UIScopes;

using UnityEngine;

using VContainer.Unity;

namespace RunThrough.UI
{
    public class UIEndPopUpPresenter : VObject<UIEndPopUpScope>, IUIPresenter
    {
        private readonly GameplayMachine gameplayMachine;
        private readonly UIEndPopUpScope.UIView uIView;
        private readonly IFade fade;

        public UIEndPopUpPresenter(GameplayMachine gameplayMachine, UIEndPopUpScope.UIView uIView, IFade fade)
        {
            this.gameplayMachine = gameplayMachine;
            this.uIView = uIView;
            this.fade = fade;
        }

        void IStartable.Start()
        {
            InitializeView();
        }

        public void InitializeModel()
        {
        }

        public async void InitializeView()
        {
            await fade.FadeInAsync(uIView.FadeableButton, UIFadeSettings.DEFAULT_FADE_DURATION, UIFadeSettings.DEFAULT_FADE_DELAY);

            uIView.Restart.OnClickAsObservable()
              .Subscribe(_ => OnClick())
              .AddTo(Scope);
        }

        private void OnClick()
        {
            Object.Destroy(Scope.gameObject);
            gameplayMachine.Enter<GameplayStart>();
        }
    }
}