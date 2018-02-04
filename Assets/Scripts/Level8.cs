using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level8 : MonoBehaviour {
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
		if (Input.anyKeyDown) {
			if (current == 0 && Input.GetKeyDown (KeyCode.N)) {
				Destroy (GameObject.Find ("blackn"));
				current++;
			} else if (current == 1 && Input.GetKeyDown (KeyCode.O)) {
				Destroy (GameObject.Find ("blacko"));
				current++;
			} else if (current == 2 && Input.GetKeyDown (KeyCode.T)) {
				Destroy (GameObject.Find ("blackt"));
				current++;
			} else if (current == 3 && Input.GetKeyDown (KeyCode.R)) {
				Destroy (GameObject.Find ("blackr"));
				current++;
			} else if (current == 4 && Input.GetKeyDown (KeyCode.E)) {
				Destroy (GameObject.Find ("blacke"));
				current++;
			} else if (current == 5 && Input.GetKeyDown (KeyCode.D)) {
				Destroy (GameObject.Find ("blackd"));
				current++;
			} else {
				SceneManager.LoadScene ("Level8");
			}
			r.material.color = new Color32 (255, (byte)(255 - 25 * current), (byte)(255 - 10.5 * current), 255);
			if (current == 6) {
				Invoke ("LoadScene", 1);
			}
		}
	}
	void LoadScene(){
		SceneManager.LoadScene ("Level9");
	}
	void OnGUI(){
		GUI.Label (new Rect (0, 0, 100, 20), "Keyboard", guiStyle);

	}
}
