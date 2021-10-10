using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Vector3 direction = new Vector3(-1, 0, 0);
    [SerializeField] float speed = 1.0f;
    [SerializeField] int hp;
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
    }

    private void OnCollisionEnter(Collision other)
    {
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
    }
}
