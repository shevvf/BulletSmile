using System;

namespace RunThrough.PlayerController
{
    public interface IPlayer : IDisposable
    {
        void Initialize();
    }
}
