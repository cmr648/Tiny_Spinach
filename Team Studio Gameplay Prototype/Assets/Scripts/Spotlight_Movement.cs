using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spotlight_Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Input.acceleration.x, Input.acceleration.y, 0); // moving our object using the gyroscope
	}
}
