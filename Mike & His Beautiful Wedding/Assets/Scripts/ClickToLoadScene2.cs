using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToLoadScene2 : MonoBehaviour {

		public string levelToLoad;
		public Color loadToColor = Color.black;
		public float timeToStart = 10.0f;

	public Material defaultMaterial;
	public Material hoveredMtrl;
	public Material clickedMtrl;
	public GameObject particles;

	public bool clicked = false;

	void Start() {
		particles.SetActive (false);
	}

	void OnMouseOver(){
		if(!clicked)
			GetComponent<Renderer> ().material = hoveredMtrl;
	}
	void OnMouseExit(){
		if(!clicked)
			GetComponent<Renderer> ().material = defaultMaterial;
	}


	void OnMouseDown(){
		if (!clicked) {
			clicked = true;
			particles.SetActive (true);
			GetComponent<Renderer> ().material = clickedMtrl;

						Invoke ("LoadScene", timeToStart);
		}
	}


		void LoadScene (){
			Initiate.Fade (levelToLoad, loadToColor, 3.0f);
		}
}