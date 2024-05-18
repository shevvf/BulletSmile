namespace RunThrough.Infrastructure.Services.EnemyService
{
    public interface IEnemyModel
    {
        int Damage { get; }
        float ReloadTime { get; }
    }
}