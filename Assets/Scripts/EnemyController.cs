using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Effect;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Vector3 direction = new Vector3(-1, 0, 0);
    [SerializeField] float speed = 1.0f;
    [SerializeField] int hp;
    PlayerHP playerHP;
    [SerializeField] AudioClip audio;

    private void Start()
    {
        playerHP = GameObject.FindObjectOfType<PlayerHP>();
    }

    void Update()
    {
        // transform.position += new Vector3(direction.x * speed, direction.y * speed, direction.z * speed) * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            playerHP.HP--;
            ParticleGenerator.Instance.PlayEnemyDeadParticle(transform.position);
            Destroy(this.gameObject);
        }
        else if(other.gameObject.CompareTag("Bullet"))
        {

            hp--;
            if (hp <= 0)
            {
                AudioManager.Instance.PlayOneShot(audio);
                ParticleGenerator.Instance.PlayEnemyDeadParticle(transform.position);
                playerHP.HP += 0.5f;
                Destroy(this.gameObject);
            }

        }

    }
}