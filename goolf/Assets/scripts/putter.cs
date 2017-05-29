using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class putter : MonoBehaviour {
    public float zForcePutter=100;
    public Camera cueCam;
    public Camera ballCam;
    // Use this for initialization
    void Start () {
       
		GetComponent<ConstantForce> ().enabled = false;

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1")) {
            GetComponent<Rigidbody>().AddRelativeForce(0, 0, zForcePutter);
			//GetComponent<ConstantForce> ().enabled = true;
            Debug.Log("Swung");
            cueCam.enabled = false;
            ballCam.enabled = true;
		}

        if (Input.GetKey ("w"))
        {
            zForcePutter += 20;
            if (zForcePutter > 1500)
            {
                zForcePutter = 1500;
            }
        }


        if (Input.GetKey("s"))
        {
            zForcePutter -= 20;
            if (zForcePutter < 20)
            {
                zForcePutter = 20;
            }
        }

    }

	void OnCollisionEnter(Collision other) {
 
        Destroy(gameObject);
        
        Debug.Log("Destroyed");


    }
}
