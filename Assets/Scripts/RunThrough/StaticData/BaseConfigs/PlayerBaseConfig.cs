using RunThrough.StaticData.BaseEntities;

using UnityEngine;

namespace RunThrough.StaticData.BaseConfigs
{
    [CreateAssetMenu(fileName = nameof(PlayerBaseConfig), menuName = "StaticData/" + nameof(PlayerBaseConfig))]
    public class PlayerBaseConfig : ScriptableObject
    {
        [field: SerializeField] public PlayerBaseEntity PlayerBaseEntity { get; private set; }
    }
}