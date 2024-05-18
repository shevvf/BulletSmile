using System;

using UnityEngine;

namespace RunThrough.ObjectFolders
{
    [Serializable]
    public class UIFolder
    {
        [field: SerializeField] public RectTransform UIMainHolder { get; private set; }

        [field: SerializeField] public RectTransform UIPopUpHolder { get; private set; }
    }
}