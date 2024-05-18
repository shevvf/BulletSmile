using RunThrough.StaticData.BaseEntities;

using UnityEngine;

namespace RunThrough.StaticData.BaseConfigs
{
    [CreateAssetMenu(fileName = nameof(EnemyBaseConfig), menuName = "StaticData/" + nameof(EnemyBaseConfig))]
    public class EnemyBaseConfig : ScriptableObject
    {
        [field: SerializeField] public EnemyBaseEntity EnemyBaseEntity { get; private set; }
    }
}