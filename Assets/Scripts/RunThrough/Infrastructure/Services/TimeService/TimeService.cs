using UnityEngine;


namespace RunThrough.Infrastructure.Services.TimeService
{
    public class TimeService : ITime
    {
        private const float NORMAL_TIME = 1.0f;
        private const float SLOWED_TIME = 0.05f;

        public void SetTime(TimeSettings timeSettings)
        {
            Time.timeScale = timeSettings == TimeSettings.Normal ? NORMAL_TIME : SLOWED_TIME;
            Debug.Log($"TimeScale: {Time.timeScale}");
        }
    }
}