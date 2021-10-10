using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecoveryItem : MonoBehaviour
{
    [SerializeField]
    float amount = 3f;

    [SerializeField]
    private GameObject recoveryUI;

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
			var obj = Instantiate<GameObject>(recoveryUI, col.transform.position - Camera.main.transform.forward * 0.5f, Quaternion.identity);
			obj.transform.SetParent(col.transform);
			Destroy(this.gameObject);
		}
	}
}
