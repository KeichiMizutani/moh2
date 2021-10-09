using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public float HP = 100f;
    float maxHP = 100f;
    public GameObject HPText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	HP -= Time.deltaTime;
	HPText.GetComponent<Text>().text = "HP : " + HP.ToString("F0");
        if(HP <= 0)
	{
		SceneManager.LoadScene("Result");
	}else if(HP > maxHP){
		HP = maxHP;
	}
    }

    void FixedUpdate()
    {
	
	
	
    }

    void OnCollisionEnter(Collision col)
    {
	
    }
}
