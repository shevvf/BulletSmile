
using System.Collections.Generic;

using R3;

using RunThrough.Infrastructure.Services.CameraService;
using RunThrough.Infrastructure.Services.InputService;
using RunThrough.Infrastructure.Services.TimeService;

using VContainer.Unity;

public class PlayerService : VObject<PlayerScope>, IStartable
{
    private readonly IInput input;
    private readonly ITime time;
    private readonly ICamera camera;

    public PlayerService(IInput input, ITime time, ICamera camera)
    {
        this.input = input;
        this.time = time;
        this.camera = camera;
    }
    void IStartable.Start()
    {
        ObserveInput();
        SetPlayerToCamera();
    }

    private void ObserveInput()
    {
        Observable
           .EveryValueChanged(input, i => i.IsMousePressed.CurrentValue, EqualityComparer<bool>.Default)
           .Select(isPressed => isPressed ? TimeSettings.Slowed : TimeSettings.Normal)
           .Subscribe(time.SetTime);
    }

    private void SetPlayerToCamera()
    {
        camera.SetPlayer(Scope.gameObject);
    }
}
