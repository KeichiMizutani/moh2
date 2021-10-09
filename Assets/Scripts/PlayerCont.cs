using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCont : MonoBehaviour
{

    float speed = 10f;
    public float forwardSpeed = 0.5f; 
    Animator anim;
    Rigidbody rb;
    float x;
    float y;
    float moveForce = 50f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal") * speed;
        y = Input.GetAxis("Vertical") * speed;
    }

    void FixedUpdate()
    {
        Vector3 moveVector = Vector3.zero;

        moveVector.x = x;
        moveVector.y = y;
        
        
        rb.AddForce(moveForce * (moveVector - rb.velocity));
        transform.position += new Vector3(0, 0, forwardSpeed);
        
        
        
    }	
}
