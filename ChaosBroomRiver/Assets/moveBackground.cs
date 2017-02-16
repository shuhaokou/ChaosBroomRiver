using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBackground : MonoBehaviour {

    public static float backgroundspeed = .05f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position -= new Vector3(backgroundspeed, 0);

        if(transform.position.x <= -120f)
        {
            transform.position = new Vector3(0, 0);
        }
	}
}
