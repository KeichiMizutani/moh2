using System;
using UnityEngine;
using Effect; //ParticleGeneratorを使うときは,using Effect;を書く

namespace Effect
{
    public class TestParticleUser : MonoBehaviour
    {
        private float timer;
        private float posZ;

        private void Start()
        {
            timer = 0.0f;
            posZ = 0.0f;
        }

        private void Update()
        {
            timer += Time.deltaTime;
            if (timer > 1.0f)
            {
                timer = 0.0f;
                ParticleGenerator.Instance.PlayEnemyDeadParticle(new Vector3(0.0f, 0.0f, posZ));
                // 敵死亡時のエフェクトを再生するコード
                // ParticleGenerator.Instance.PlayEnemyDeadParticle(再生する座標Vector3);
                posZ += 2f;
            }
        }
    }
}
