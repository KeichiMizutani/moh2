using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCont : MonoBehaviour
{

    float speed = 10f;
    public float forwardSpeed = 1f; 
    public float rotateSpeed = 1f;
 
    Animator anim;
    Rigidbody rb;
    float x;
    float y;
    float AngleX;
    float AngleY;
    public float minAngle = -10f;
    public float maxAngle = 10f;
    float moveForce = 50f;

    public GameObject bullet;
    public GameObject rightDiagonalBullet;
    public GameObject leftDiagonalBullet;

    public bool powerUp = false;
    public Slider powerUpSlider;
    float time = 0; 
    Vector3 rotEuler;

 
    
    [SerializeField]
    float powerUpTime = 5f; 



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
	rotEuler = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, transform.localEulerAngles.z);
	powerUpSlider.value = 1;
    }



    // Update is called once per frame
    void Update()
    {
	x = Input.GetAxis("Horizontal") * speed;
	y = Input.GetAxis("Vertical") * speed;
	AngleX = Input.GetAxis("Horizontal") * rotateSpeed;
	AngleY = Input.GetAxis("Vertical") * rotateSpeed;

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
		powerUpSlider.gameObject.SetActive(true);
		time += Time.deltaTime;
		powerUpSlider.value = (powerUpTime - time) / powerUpTime;
		
		if(time >= powerUpTime)
		{
			powerUp = false;
			time = 0;
			powerUpSlider.gameObject.SetActive(false);
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
	rotEuler = new Vector3(Mathf.Clamp(rotEuler.x - AngleY, minAngle, maxAngle), Mathf.Clamp(rotEuler.y + AngleX, minAngle, maxAngle), Mathf.Clamp(rotEuler.z - AngleX, minAngle, maxAngle));
        transform.localEulerAngles = rotEuler;
	

	
	
        
        
    }	
}
