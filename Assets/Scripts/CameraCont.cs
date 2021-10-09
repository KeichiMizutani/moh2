using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCont : MonoBehaviour
{
    Vector3 diff;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
	diff = target.transform.position - transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position - diff, Time.deltaTime * 10.0f);

	/*transform.position += new Vector3(0, 0, 0.5f);*/
    }
}
