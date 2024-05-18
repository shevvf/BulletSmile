using RunThrough.StaticData.BaseConfigs;

namespace RunThrough.Infrastructure.Services.EnemyService
{
    public class EnemyModel : IEnemyModel
    {
        private readonly EnemyBaseConfig enemyBaseConfig;

        public EnemyModel(EnemyBaseConfig enemyBaseConfig)
        {
            this.enemyBaseConfig = enemyBaseConfig;
        }

        public int Damage => enemyBaseConfig.EnemyBaseEntity.Damage;
        public float ReloadTime => enemyBaseConfig.EnemyBaseEntity.ReloadTime;
    }
}