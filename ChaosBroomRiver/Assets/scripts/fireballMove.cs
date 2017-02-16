 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position += new Vector3(.8f, 0f);
	}

    
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Monsters")
        {
            Destroy(col.gameObject);
            //score++ 
        }
    }

}