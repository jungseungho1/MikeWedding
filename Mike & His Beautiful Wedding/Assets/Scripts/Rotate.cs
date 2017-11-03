using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	public Vector3 center;
	public Vector3 axis;
	public float orbitSpeed = 30.0F; 	// degrees per second
	public float rotateSpeed = 20.0F;	// degrees per second

	void Start () {
		center = new Vector3 (0, 0, 0);
		axis = new Vector3 (0,1f,0);
	}

	void Update () {
		this.transform.RotateAround (center, Vector3.up, Time.deltaTime * orbitSpeed);
		this.transform.Rotate (axis, Time.deltaTime * rotateSpeed);
	}
}
