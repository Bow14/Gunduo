﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float moveSpeed = 20f;
	
	// Update is called once per frame
	void Update () {
		
		//Moving around
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector3.left*moveSpeed*Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector3.right*moveSpeed*Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}	
		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
		}
		
	}
}

