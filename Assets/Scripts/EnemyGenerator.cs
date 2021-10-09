using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] enemy;
    [SerializeField] int[] enemyFrequency;
    [SerializeField] int enemyNum;
    


    // [SerializeField] GameObject respawnPos;
    [SerializeField] float maxr = 8;
    int theta;
    [SerializeField] float lifeTime = 10f;

    private void Start()
    {
        GenerateEnemy();
    }

    public void GenerateEnemy()
    {
        Vector3 centor = gameObject.transform.position + new Vector3(-8, 0, -8);
        Debug.Log(centor);
        
        // float rangeX = Random.Range(0, 8);
        // float rangeY = Random.Range(0, 8);
        // float rangeZ = Random.Range(0, 8);


        //EnemyNumだけ敵を生成
        for (int i = 0; i < enemyNum; i++)
        {
            theta = Random.Range(0, 360);
            float r = Random.Range(0, maxr);

            Destroy(Instantiate(ChooseEnemy(),
                        new Vector3(centor.x + Mathf.Cos(Mathf.PI * 2 / 180 * theta) * r,
                                    centor.y + Mathf.Sin(Mathf.PI * 2 / 180 * theta) * r,
                                    centor.z + Random.Range(-8, 8)),
                                    Quaternion.identity),
                                    lifeTime);
        }
    }

   
    GameObject ChooseEnemy()
    {
        
        int rnd=Random.Range(0, enemyFrequency[0]+enemyFrequency[1]+enemyFrequency[2]+enemyFrequency[3]);
        
        if(rnd <enemyFrequency[0])   return enemy[0];
        else if(rnd >= enemyFrequency[0] && rnd < enemyFrequency[1])   return enemy[1];
        else if(rnd >= enemyFrequency[1] && rnd < enemyFrequency[2])   return enemy[2];
        else return enemy[3];
                
        // return e;
    }
}
