using System;

using UnityEngine;

namespace RunThrough.StaticData.BaseEntities
{
    [Serializable]
    public class PlayerBaseEntity
    {
        [field: SerializeField] public int Health { get; private set; }
    }
}