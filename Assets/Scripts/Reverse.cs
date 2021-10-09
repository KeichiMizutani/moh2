using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Reverse : MonoBehaviour
{

    void Start()
    {
         gameObject.transform.GetComponent<MeshFilter>().mesh.triangles.Reverse().ToArray();
	gameObject.AddComponent<MeshCollider>();
    }
}

