using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public GameObject Player;

    private float timer = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer -= 1.0f * Time.deltaTime;
        if (timer <= 0)
            Player.SetActive(false);
	}
}
