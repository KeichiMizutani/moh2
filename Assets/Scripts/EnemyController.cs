using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    PlayerCont playerCont;
    PlayerHP playerHP;    

    [SerializeField] Vector3 direction = new Vector3(-1, 0, 0);
    [SerializeField] float speed = 1.0f;
    [SerializeField] int hp;

    private void Start() 
    {
        playerCont = GameObject.FindObjectOfType<PlayerCont>();
        playerHP = GameObject.FindObjectOfType<PlayerHP>();
    }
    void Update()
    {
        transform.position += new Vector3(direction.x * speed, direction.y * speed, direction.z * speed);
    }

    private void OnCollisionEnter(Collision other)
    {
        //あたったのが弾だったら自身にダメージ
        if (other.gameObject.CompareTag("Bullet"))
        {
            //パワーアップ中だったらめっちゃ減る
            if(playerCont.powerUp) hp-=100;

            hp--;
            Destroy(other.gameObject);
            if (hp <= 0) Destroy(this.gameObject);
        }

        //あたったのがプレイヤーだったらプレイヤーにダメージ
        if (other.gameObject.CompareTag("Player"))
        {
            playerHP.HP --;
            Destroy(this.gameObject);
        }
        
    }
}
