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
    float moveForce = 50f;
    public GameObject bullet;
    public GameObject rightDiagonalBullet;
    public GameObject leftDiagonalBullet;
    public bool powerUp = false;
    public GameObject powerUpTimeText;
    float time = 0; 
    float cooltime;
 
    
    [SerializeField]
    float powerUpTime = 5f; 

     AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
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
        audio.Play();
	    	
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


	/*if(transform.rotation.eulerAngles.x >= 20f){
		transform.rotation = Quaternion.Euler(20f, transform.rotation.eulerAngles.y ,transform.rotation.eulerAngles.z);
		}else if(transform.rotation.eulerAngles.x <= -20f)
		{
			transform.rotation = Quaternion.Euler(-20f, transform.rotation.eulerAngles.y ,transform.rotation.eulerAngles.z);
		}*/
		
	

	/*if(Mathf.Abs(transform.rotation.eulerAngles.y) >= 20f){
		transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 20f ,transform.rotation.eulerAngles.z);
	}*/

	/*if(transform.rotation.eulerAngles.z >= 20f){
		transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 20f);
	}*/

	
		
	
	
	
	
    }

    void FixedUpdate()
    {
        Vector3 moveVector = Vector3.zero;
	
	

	moveVector.x = x;
	moveVector.y = y;
	rb.AddForce(moveForce * (moveVector - rb.velocity));
	transform.position += new Vector3(0, 0, forwardSpeed);
	/*transform.RotateAround(transform.position, Vector3.up, AngleX);
	transform.RotateAround(transform.position, Vector3.forward, AngleX);
	transform.RotateAround(transform.position, Vector3.right, AngleY);*/

	
	
        
        
    }	
}
