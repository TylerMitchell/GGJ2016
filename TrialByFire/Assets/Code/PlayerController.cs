﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 1000.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float mod = speed * Time.deltaTime;
		GetComponent<Rigidbody2D>().AddForce(new Vector3(Input.GetAxis("Horizontal") * mod, Input.GetAxis("Vertical") * mod, 0f));
		//transform.Translate(Input.GetAxis("Horizontal") * mod, Input.GetAxis("Vertical") * mod, 0f);
		// this is a stupid comment
	}
}
