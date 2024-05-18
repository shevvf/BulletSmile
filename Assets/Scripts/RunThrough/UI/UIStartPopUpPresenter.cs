using Cysharp.Threading.Tasks;

using R3;

using RunThrough.Game.GameplayStateMachine;
using RunThrough.Game.GameplayStateMachine.States;
using RunThrough.Infrastructure.Services.FadeService;
using RunThrough.LifetimeScopes.UIScopes;

using UnityEngine;

using VContainer.Unity;

namespace RunThrough.UI
{
    public class UIStartPopUpPresenter : VObject<UIStartPopUpScope>, IUIPresenter
    {
        private readonly GameplayMachine gameplayMachine;
        private readonly UIStartPopUpScope.UIView uIView;
        private readonly IFade fade;

        public UIStartPopUpPresenter(GameplayMachine gameplayMachine, UIStartPopUpScope.UIView uIView, IFade fade)
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

        public void InitializeView()
        {
            uIView.Start.OnClickAsObservable()
               .Subscribe(_ => OnClick())
               .AddTo(Scope);
        }

        private async void OnClick()
        {
            await fade.FadeOutAsync(uIView.FadeablePanel, UIFadeSettings.DEFAULT_FADE_DURATION);
            Object.Destroy(Scope.gameObject);

            gameplayMachine.Enter<GameplayLoop>();
        }
    }
}