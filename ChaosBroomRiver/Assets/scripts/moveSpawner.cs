using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSpawner : MonoBehaviour {

    public Vector2 start;
    public Vector2 end;
    public float speed;
    private Vector2 destination;

	// Use this for initialization
	void Start () {
        transform.position = start;	
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector2.Distance(start, transform.position) < 0.5 ) {
            destination = end;
        }
        else if (Vector2.Distance(end, transform.position) < 0.5) {
                destination = start;
        }

        Vector2 pos = Vector2.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        transform.position = pos;
	}
}
