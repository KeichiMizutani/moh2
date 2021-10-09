using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Vector3 direction=new Vector3(-1,0,0);
    [SerializeField] float speed=1.0f;
    [SerializeField] int hp;
    void Update()
    {
        transform.position+=new Vector3(direction.x*speed, direction.y*speed, direction.z*speed) * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other) {
        hp--;
        if(hp <= 0) Destroy(this.gameObject);
    }
}
