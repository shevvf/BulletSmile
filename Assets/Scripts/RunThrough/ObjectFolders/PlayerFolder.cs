using System;

using UnityEngine;

namespace RunThrough.ObjectFolders
{
    [Serializable]
    public class PlayerFolder
    {
        [field: SerializeField] public Transform PlayerInitPosition { get; private set; }
    }
}