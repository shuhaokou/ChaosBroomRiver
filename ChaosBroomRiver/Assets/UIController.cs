using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

    public static float score;
    public float highscore;
    public GUIText scoreui;
    public GUIText highscoreui;

    public GameObject titlescreen;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(score > highscore)
        {
            highscore = score; 
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            titlescreen.SetActive(false);
            moveBackground.backgroundspeed = .2f;
        }
	}
}
