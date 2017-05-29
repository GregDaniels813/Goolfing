using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ballControl : MonoBehaviour {

    public Transform clubObj;
    public Transform arrowObj;
    public Camera cueCam;
    public Camera ballCam;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown("space"))
        {

            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            Instantiate(clubObj, new Vector3((transform.position.x), (transform.position.y), (transform.position.z)), clubObj.rotation);
            Instantiate(arrowObj, transform.position, arrowObj.rotation);
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);
            Debug.Log("Created");
            ballCam.enabled = false;
            cueCam.enabled = true;
            

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name.StartsWith("cup"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            Debug.Log("Completed");
            StartCoroutine(delayLoad());

        }
    }
    IEnumerator delayLoad()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("golfTestRed1");
    }
}
