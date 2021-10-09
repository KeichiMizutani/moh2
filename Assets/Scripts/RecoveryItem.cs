using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoveryItem : MonoBehaviour
{
    [SerializeField]
    float amount = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Player"){
			col.gameObject.GetComponent<PlayerHP>().HP += amount;
			Destroy(this.gameObject);
		}
	}
}
