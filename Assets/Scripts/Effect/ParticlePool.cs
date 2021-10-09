using UnityEngine;
using UniRx.Toolkit;

namespace Effect
{
    public class ParticlePool : ObjectPool<EnemyDeadParticle>
    {
        private readonly Transform _parentTransform;
        private readonly EnemyDeadParticle _prefab;
        
        //コンストラクタ
        public ParticlePool(Transform parentTransform, EnemyDeadParticle prefab)
        {
            _parentTransform = parentTransform;
            _prefab = prefab;
        }
        
        /// <summary>
        /// オブジェクトの追加生成時に実行される
        /// </summary>
        /// <returns></returns>
        protected override EnemyDeadParticle CreateInstance()
        {
            //新しく生成
            var e = Object.Instantiate(_prefab, _parentTransform, true);
            return e;
        }
    }
}
