using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMouse : MonoBehaviour {
    public float distance = 15.0f;
    private float actualDistance;
    // Use this for initialization
    void Start () {
        Vector3 toObjectVector = transform.position - Camera.main.transform.position;
        Vector3 linearDistanceVector = Vector3.Project(toObjectVector, Camera.main.transform.forward);
        actualDistance = linearDistanceVector.magnitude;

    }

    // Update is called once per frame
    void Update () {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = distance;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
        if (transform.position.x > 0)
        {
            transform.position = new Vector3(0f, transform.position.y);
        }
	}
}   
