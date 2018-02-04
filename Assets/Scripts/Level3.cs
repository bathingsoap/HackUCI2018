using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level3 : MonoBehaviour {
	SpriteRenderer r;
	int current = 0;
	private GUIStyle guiStyle = new GUIStyle();

	// Use this for initialization
	void Start () {
		r = GameObject.Find("white").GetComponent<SpriteRenderer>();
		r.material.color = new Color32 (255, 255, 255, 255);
		guiStyle.normal.textColor = Color.black;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) {
			Destroy (GameObject.Find ("blackp"));
			current++;
		}
		if (Input.GetKeyDown (KeyCode.I)) {
			Destroy (GameObject.Find ("blacki"));
			current++;
		}
		if (Input.GetKeyDown (KeyCode.N)) {
			Destroy (GameObject.Find ("blackn"));
			current++;
		}
		if (Input.GetKeyDown (KeyCode.K)) {
			Destroy (GameObject.Find ("blackk"));
			current++;
		}
		if (current == 1) {
			r.material.color = new Color32 (255, 225, 232, 255);
		}
		else if (current == 2) {
			r.material.color = new Color32 (255, 185, 218, 255);
		}
		else if (current == 3) {
			r.material.color = new Color32 (255, 145, 202, 255);
		}
		else if (current == 4) {
			r.material.color = new Color32 (255, 105, 192, 255);
			Invoke ("LoadScene", 1);
		}
	}
	void LoadScene(){
		SceneManager.LoadScene ("Level4");
	}
	void OnGUI(){
		GUI.Label (new Rect (0, 0, 100, 20), "Keyboard", guiStyle);

	}
}
