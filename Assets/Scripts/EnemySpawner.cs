using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject[] enemy;
    // [SerializeField] GameObject respawnPos;
    [SerializeField] float r;
    int theta;

    float time;
    [SerializeField] float respawnCycle;
    [SerializeField] float lifeTime = 5f;

    public void Spawn()
    {
        Vector3 pos = gameObject.transform.position;
        theta = Random.Range(0, 360);
        Destroy(Instantiate(enemy[Random.Range(0, enemy.Length)],
                    new Vector3(pos.x +  Mathf.Cos(Mathf.PI*2 / 180 * theta) * Random.Range(0,r), pos.y + Mathf.Sin(Mathf.PI*2 / 360 * theta) * Random.Range(0,r), pos.z),
                    Quaternion.identity), lifeTime);
    }

    private void Update()
    {
        // Debug.Log(time);
        time += Time.deltaTime;
        if (time >= respawnCycle)
        {
            Spawn();
            time = 0;
        }
    }
}
