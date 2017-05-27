using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballControl : MonoBehaviour {
    public int index = 0;
    public Transform clubObj;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown("space"))
        {

            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            Instantiate(clubObj, new Vector3((transform.position.x), (transform.position.y), (transform.position.z)), clubObj.rotation);
            index = +1;
            Debug.Log("Created" + index);

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "cup")
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            Debug.Log("Completed");
        }
    }

}
