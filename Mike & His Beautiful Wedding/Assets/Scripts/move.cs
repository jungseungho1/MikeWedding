using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public float speed = 1.0f;
	public float speed1 = 1.0f;

	void Update () {
		if (Input.GetKeyDown("space") == true){
			transform.Translate (0, 0, speed);
		}
		if (Input.GetKey("z") == true){
			transform.Translate (0, 0, speed1);
		}
	}
}