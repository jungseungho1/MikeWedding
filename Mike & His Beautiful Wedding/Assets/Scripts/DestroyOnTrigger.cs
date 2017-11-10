using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnTrigger : MonoBehaviour {

	public GameObject destroyThis;
	public GameObject CreateThis;
	public Transform CreateHere1;
	public bool alreadyPlayed = false;
	public string levelToLoad;
	public Color loadToColor = Color.black;
	public float timeToStart = 1.0f;

	void OnTriggerEnter(Collider other){
		if (!alreadyPlayed) {
			if (other.gameObject.tag == "Player") {
				Instantiate (CreateThis, CreateHere1.position, CreateHere1.rotation );
				Destroy (destroyThis);
				Invoke ("LoadScene1", timeToStart);
			}
		}
	}

	void LoadScene1 (){
		Initiate.Fade (levelToLoad, loadToColor, 5.0f);
	}
}
