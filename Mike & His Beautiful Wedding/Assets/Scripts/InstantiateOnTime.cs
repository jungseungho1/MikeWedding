using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstantiateOnTime : MonoBehaviour {

	public float timeToStart = 3.0f;
	public GameObject CreateThis;
	public Transform CreateHere;

	void Start () {
		Invoke ("CreateIt", timeToStart);
	}

	void CreateIt (){
		Instantiate (CreateThis, CreateHere.position, CreateHere.rotation );
	}
}
