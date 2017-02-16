﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterSpawner : MonoBehaviour {

	public GameObject monsterPrefab;
	public float initialFroce;
	public float initialAngle;

	// Use this for initialization
	void Start () {
		Invoke ("CreateMonster", Random.Range (0.5f, 3f));
	}
	
	// Update is called once per frame

	void CreateMonster() {
		float angle = Mathf.Deg2Rad * (initialAngle + Random.Range (-10, 10));
		GameObject monster = Instantiate (monsterPrefab) as GameObject;
		monster.transform.position = transform.position;
		Rigidbody body = monster.GetComponent<Rigidbody> ();
		body.AddForce (new Vector2 (Mathf.Cos (angle), Mathf.Sin (angle)) * (initialFroce * Random.Range (0.5f, 2f)));
		Invoke ("CreateMonster", Random.Range (0.5f, 3f));
	}
}
