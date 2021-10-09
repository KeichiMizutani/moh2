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
    public GameObject bullet;
    public GameObject rightDiagonalBullet;
    public GameObject leftDiagonalBullet;
    public bool powerUp = false;
    
    [SerializeField]
    float powerUpTime = 5f; 

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

	if(Input.GetKey(KeyCode.Space)){
		if(!powerUp)
		{
			Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1f), Quaternion.identity);
		}else{
			Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1f), Quaternion.identity);
			Instantiate(rightDiagonalBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1f), Quaternion.identity);
			Instantiate(leftDiagonalBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1f), Quaternion.identity);
		}
	    	
	}

	
	if(powerUp){
		float time = 0;
		time += Time.deltaTime;
		if(time >= powerUpTime){
			powerUp = false;
		}
	}
		
	

	
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
