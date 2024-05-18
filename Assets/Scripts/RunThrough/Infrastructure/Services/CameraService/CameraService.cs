using RunThrough.ObjectFolders;

using UnityEngine;

namespace RunThrough.Infrastructure.Services.CameraService
{
    public class CameraService : ICamera
    {
        private readonly MainFolder mainFolder;

        public CameraService(MainFolder mainFolder)
        {
            this.mainFolder = mainFolder;
        }

        public void SetPlayer(GameObject player)
        {
            mainFolder.MainCamera.Follow = player.transform;
        }
    }
}