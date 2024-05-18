using System;
using System.Collections.Generic;

using UnityEngine;

namespace RunThrough.ObjectFolders
{
    [Serializable]
    public class EnemyFolder
    {
        [field: SerializeField] public List<Transform> EnemyInitPositions { get; private set; }
    }
}