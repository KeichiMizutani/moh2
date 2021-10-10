using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] item;
    

    [SerializeField] float maxr = 8;
    int theta;

    private void Start()
    {
        GenerateItem();
    }

    public void GenerateItem()
    {
        Vector3 centor = gameObject.transform.position + new Vector3(-8, 0, -8);
        Debug.Log(centor);
        
        // float rangeX = Random.Range(0, 8);
        // float rangeY = Random.Range(0, 8);
        // float rangeZ = Random.Range(0, 8);


            theta = Random.Range(0, 360);
            float r = Random.Range(0, maxr);

            Instantiate(item[Random.Range(0, item.Length )],
                        new Vector3(centor.x + Mathf.Cos(Mathf.PI * 2 / 180 * theta) * r,
                                    centor.y + Mathf.Sin(Mathf.PI * 2 / 180 * theta) * r,
                                    centor.z + Random.Range(-8, 8)),
                                    Quaternion.identity);
        }
    }