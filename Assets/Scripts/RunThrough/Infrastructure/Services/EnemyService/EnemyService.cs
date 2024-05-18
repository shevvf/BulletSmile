using System.Threading;

using Cysharp.Threading.Tasks;

using DG.Tweening;

using R3;
using R3.Triggers;

using RunThrough.LifetimeScopes.EntityScopes;

using UnityEngine;

using VContainer.Unity;

namespace RunThrough.Infrastructure.Services.EnemyService
{
    public class EnemyService : VObject<EnemyScope>, IStartable
    {
        private const float ROTATE_TO_PLAYER_DURATION = 2.0f;

        public EnemyService()
        {

        }

        void IStartable.Start()
        {
            Scope.OnTriggerStayAsObservable()
                .Select(collision => collision.transform.position)
                .DistinctUntilChanged()
                .SubscribeAwait(async (collision, ct) =>
                {
                    await RotateToPlayer(collision, ct);

                }, AwaitOperation.Switch)
                .AddTo(Scope.destroyCancellationToken);
        }

        private async UniTask RotateToPlayer(Vector3 target, CancellationToken ct)
        {
            Vector3 direction = (target - Scope.transform.position).normalized;

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion targetRotation = Quaternion.Euler(0f, -angle, 0f);

            Scope.transform.DOKill();
            await Scope.transform.DOLocalRotateQuaternion(targetRotation, ROTATE_TO_PLAYER_DURATION).AsyncWaitForCompletion();
            Scope.transform.DOKill();
        }
    }
}