using System;

using UnityEngine;

namespace RunThrough.StaticData.BaseEntities
{
    [Serializable]
    public class EnemyBaseEntity
    {
        [field: SerializeField] public int Damage { get; private set; }

        [field: SerializeField] public float ReloadTime { get; private set; }
    }
}