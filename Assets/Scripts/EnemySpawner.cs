using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject[] enemy;
    [SerializeField] GameObject respawnPos;
    [SerializeField] float r;
    int theta;

    float time;
    [SerializeField] float respawnCycle;

    public void Spawn()
    {
        Vector3 pos = respawnPos.transform.position;
        theta = Random.Range(0, 360);
        Destroy(Instantiate(enemy[Random.Range(0, enemy.Length)],
                    new Vector3(pos.x + 2 * Mathf.Cos(Mathf.PI / 180 * theta) * Random.Range(0,r), pos.y + 2 * Mathf.Sin(Mathf.PI / 360 * theta) * Random.Range(0,r), pos.z + 2 * Mathf.Sin(Mathf.PI / 360 * theta) * Random.Range(0,r)),
                    Quaternion.identity), 5f);
    }

    private void Update()
    {
        Debug.Log(time);
        time += Time.deltaTime;
        if (time >= respawnCycle)
        {
            Spawn();
            time = 0;
        }
    }
}
