using System;

using UnityEngine;

namespace RunThrough.ObjectFolders
{
    [Serializable]
    public class LevelFolder
    {
        [field: SerializeField] public PlayerFolder PlayerFolder { get; private set; }

        [field: SerializeField] public EnemyFolder EnemyFolder { get; private set; }
    }
}