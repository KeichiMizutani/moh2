using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public float HP = 100f;
    public float maxHP = 100f;
    public GameObject HPText;
    public float amountOfDamage = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	HP -= Time.deltaTime * amountOfDamage;
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
	if(col.gameObject.tag == "Stage"){
			amountOfDamage = 3f;
		}
    }

	void OnCollisionExit(Collision col){
		if(col.gameObject.tag == "Stage"){
			amountOfDamage = 1f;
		}
	}

	
}
