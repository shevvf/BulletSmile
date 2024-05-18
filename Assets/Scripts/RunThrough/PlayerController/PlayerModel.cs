using R3;

using RunThrough.StaticData.BaseConfigs;

namespace RunThrough.PlayerController
{
    public class PlayerModel : IPlayerModel
    {
        private readonly PlayerBaseConfig playerBaseConfig;

        private ReactiveProperty<int> currentHealth;

        public PlayerModel(PlayerBaseConfig playerBaseConfig)
        {
            this.playerBaseConfig = playerBaseConfig;
        }

        public ReactiveProperty<int> CurrentHealth
        {
            get
            {
                currentHealth ??= new(playerBaseConfig.PlayerBaseEntity.Health);
                return currentHealth;
            }
            set
            {
                currentHealth.Value = value.Value;
            }
        }
    }
}