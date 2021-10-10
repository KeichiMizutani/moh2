using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Effect;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Vector3 direction = new Vector3(-1, 0, 0);
    [SerializeField] float speed = 1.0f;
    [SerializeField] int hp;
<<<<<<< HEAD
    PlayerHP playerHP;
    [SerializeField] AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
        playerHP = GameObject.FindObjectOfType<PlayerHP>();
    }

    void Update()
    {
        // transform.position += new Vector3(direction.x * speed, direction.y * speed, direction.z * speed) * Time.deltaTime;
=======

    void Update()
    {
        transform.position +=
            new Vector3(direction.x * speed, direction.y * speed, direction.z * speed) * Time.deltaTime;
>>>>>>> origin/feature/mittani
    }

    private void OnCollisionEnter(Collision other)
    {
<<<<<<< HEAD
        if (other.gameObject.CompareTag("Player"))
        {
            playerHP.HP--;
            Destroy(this.gameObject);
        }
        else
        {

            hp--;
            if (hp <= 0)
            {
                audio.Play();
                Destroy(this.gameObject);
            }

        }
=======
        hp--;
        if (hp <= 0)
        {
            ParticleGenerator.Instance.PlayEnemyDeadParticle(transform.position);
            Destroy(this.gameObject);
        }
>>>>>>> origin/feature/mittani
    }
}