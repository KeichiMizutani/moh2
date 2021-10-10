using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCont : MonoBehaviour
{
    public float speed = 1f;
    GameObject player;
    public float distance = 10f;
    public bool rightDiagonal = false;
    public bool leftDiagonal = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (rightDiagonal && !leftDiagonal)
        {
            transform.position += new Vector3(speed, 0, speed);
        }
        else if (!rightDiagonal && leftDiagonal)
        {
            transform.position += new Vector3(-speed, 0, speed);
        }
        else if (!rightDiagonal && !leftDiagonal)
        {
            transform.position += new Vector3(0, 0, speed);
        }
        else
        {
            transform.position += new Vector3(0, 0, speed);
        }

        if (transform.position.z - player.transform.position.z >= distance)
        {
            Destroy(this.gameObject);
        }
    }

}