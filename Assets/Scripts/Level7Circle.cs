using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level7Circle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	/*
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "blackcircle") {
			Destroy (col.gameObject);
			Invoke ("EndGame", 0.3f);
		}
	}*/

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "blackcircle") {
			Invoke ("EndGame", 0.3f);
		}

	}
	void EndGame(){
		Destroy (GameObject.Find("blackcircle").gameObject);
		GameObject.Find ("background").GetComponent<SpriteRenderer> ().material.color = new Color32 (255, 105, 192, 255);

		Invoke ("EndGame2", 1.5f);
	}

	void EndGame2(){
		foreach (SpriteRenderer c in GameObject.Find("surrounding").GetComponentsInChildren<SpriteRenderer>()) {
			c.material.color = new Color32 (255, 105, 192, 255);
		}
		Invoke ("LoadScene", 1f);
	}
	void LoadScene(){
		SceneManager.LoadScene ("Level8");
	}
}
