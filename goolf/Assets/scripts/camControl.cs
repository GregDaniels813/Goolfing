using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControl : MonoBehaviour {

    public Transform ballObj;
    public Transform pivotObj;
	// Use this for initialization
	void Start () {

        
		
	}
	
	// Update is called once per frame
	void Update () {
		
        GetComponent<Rigidbody>().velocity = new Vector3 (ballObj.GetComponent<Rigidbody>().velocity.x, 0, ballObj.GetComponent<Rigidbody>().velocity.z);
        transform.LookAt(ballObj);

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            GetComponent<Camera>().fieldOfView -= 1;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            GetComponent<Camera>().fieldOfView += 1;
        }


    }
}
