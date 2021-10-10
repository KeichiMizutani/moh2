using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public float HP = 100f;
    public float maxHP = 100f;
    public Slider HpSlider;
    public float amountOfDamage = 1f;

    // Start is called before the first frame update
    void Start()
    {
        HpSlider.value = 1;
	HP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
	HP -= Time.deltaTime * amountOfDamage;
	HpSlider.value = HP / maxHP;
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
