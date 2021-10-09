using System;
using UnityEngine;
using UniRx;
using UniRx.Triggers;


namespace Effect
{
    public class ParticleGenerator : SingletonMonoBehaviour<ParticleGenerator>
    {
        [SerializeField, TooltipAttribute("敵死亡時のエフェクトのPrefab")]
        private GameObject enemyDeadParticlePrefab;

        private ParticlePool _particlePool;

        private void Start()
        {
            // オブジェクトプールを作成
            _particlePool = new ParticlePool(transform, enemyDeadParticlePrefab.GetComponent<EnemyDeadParticle>());

            // 破棄されたときにPoolを解放する
            this.OnDestroyAsObservable().Subscribe(_ => _particlePool.Dispose());
        }

        public void PlayEnemyDeadParticle(Vector3 pos)
        {
            //Poolから1つ取得
            var particle = _particlePool.Rent();

            //パーティクルを再生し、再生終了したらPoolに返却する
            particle.PlayParticle(pos).Subscribe(__ => { _particlePool.Return(particle); });
        }
    }
}