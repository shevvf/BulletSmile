using System.Collections.Generic;

using UnityEngine;

namespace RunThrough.StaticData.BaseConfigs
{
    [CreateAssetMenu(fileName = nameof(LevelBaseConfig), menuName = "StaticData/" + nameof(LevelBaseConfig))]
    public class LevelBaseConfig : ScriptableObject
    {
        [field: SerializeField] public List<GameObject> EnemyPrefabs { get; private set; }
    }
}