using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, 0, -1);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(0, 0, 1);

        }
        if (Input.GetKeyDown("space"))
        {
            
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);

        }

        if (Input.GetButtonDown("Fire1"))
        {
            Destroy(gameObject);
        }

    }
}
