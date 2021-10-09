using UnityEngine;
using UniRx;
using System;

namespace Effect
{
    /// <summary>
    /// エフェクトを再生して一定時間後に通知する
    /// </summary>
    public class EnemyDeadParticle : MonoBehaviour
    {
        ParticleSystem _particle;

        private void Awake()
        {
            _particle = GetComponent<ParticleSystem>();
        }

        public IObservable<Unit> PlayParticle(Vector3 position)
        {
            transform.position = position;

            _particle.Play();

            return Observable.Timer(TimeSpan.FromSeconds(1.0f)).ForEachAsync(_ => _particle.Stop());
        }
    }
}