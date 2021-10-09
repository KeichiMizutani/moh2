using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCont : MonoBehaviour
{

    float speed = 10f;
    public float forwardSpeed = 1f; 
    Animator anim;
    Rigidbody rb;
    float x;
    float y;
    float moveForce = 50f;
    public GameObject bullet;
    public GameObject rightDiagonalBullet;
    public GameObject leftDiagonalBullet;
    public bool powerUp = false;
    public GameObject powerUpTimeText;
    float time = 0; 
 
    
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
		powerUpTimeText.SetActive(true);
		time += Time.deltaTime;
		powerUpTimeText.GetComponent<Text>().text = "弾増加中：" + "残り" + (powerUpTime - time).ToString("F0") + "秒";
		
		
		if(time >= powerUpTime)
		{
			powerUp = false;
			time = 0;
			powerUpTimeText.SetActive(false);
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
