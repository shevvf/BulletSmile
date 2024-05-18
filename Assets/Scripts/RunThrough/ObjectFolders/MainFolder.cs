using System;

using Cinemachine;

using UnityEngine;

namespace RunThrough.ObjectFolders
{
    [Serializable]
    public class MainFolder
    {
        [field: SerializeField] public CinemachineVirtualCamera MainCamera { get; private set; }

        [field: SerializeField] public Transform LevelInitPosition { get; private set; }

        [field: SerializeField] public UIFolder UIFolder { get; private set; }
    }
}