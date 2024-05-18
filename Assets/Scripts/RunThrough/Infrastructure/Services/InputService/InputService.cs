using R3;

using UnityEngine.InputSystem;

namespace RunThrough.Infrastructure.Services.InputService
{
    public class InputService : IInput
    {
        private readonly InputActionReference inputActionReference;

        private ReactiveProperty<bool> isMousePressed = new(false);

        public InputService(InputActionReference inputActionReference)
        {
            this.inputActionReference = inputActionReference;
        }

        public ReadOnlyReactiveProperty<bool> IsMousePressed
        {
            get
            {
                isMousePressed = new(inputActionReference.action.IsPressed());
                return isMousePressed;
            }
        }
    }
}