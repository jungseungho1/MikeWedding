using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraCall : MonoBehaviour {

	Animator myAnimator;
	public float timeToStart = 0.5f;

	void Start () {
		myAnimator = this.GetComponent<Animator> ();
	}

	void Update () {
		if ((GameObject.Find ("Diamond").GetComponent<clickToLoadScene> ().clicked == true)) {
			Invoke ("move", timeToStart);
		}
	}

	public void move (){
		myAnimator.SetTrigger ("clicked");
	}
}
