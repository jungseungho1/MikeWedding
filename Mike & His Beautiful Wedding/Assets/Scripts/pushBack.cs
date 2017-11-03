using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushBack : MonoBehaviour {

	public float speed = 1.0f;

	void Update () {
//		this.GetComponent<Rigidbody>().AddForce(0,0,-speed);
		transform.Translate (0, 0, -speed);
	}

}