using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class broomShoot : MonoBehaviour {

    public GameObject fireballprefab;
	public float initialAngle;
	public float initialForce;
	
	// Update is called once per frame
	void Update () {
	
        /*if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballprefab, new Vector3(transform.position.x + 3f, transform.position.y), Quaternion.identity);
        }*/


	}

	void Start () {
		Invoke ("Shooting", 0.5f);
	}

	// Update is called once per frame

	void Shooting() {
		Instantiate(fireballprefab, new Vector3(transform.position.x + 3f, transform.position.y), Quaternion.identity);
		Invoke ("Shooting", 0.5f);
	}
}
