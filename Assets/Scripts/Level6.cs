using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level6 : MonoBehaviour {
	Font myfont;
	SpriteRenderer r;
	bool going;
	int current;
	float t;
	private GUIStyle guiStyle = new GUIStyle();
	private GUIStyle guiStyle2 = new GUIStyle();

	// Use this for initialization
	void Start () {
		r = GameObject.Find("white").GetComponent<SpriteRenderer>();
		r.material.color = new Color32 (255, 255, 255, 255);
		going = false;
		current = 0;
		guiStyle2.font = (Font)Resources.Load ("Xanadu");
		guiStyle.normal.textColor = Color.black;
		//myfont = "Xanadu";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9)) {
			going = true;
			t = Time.time;
			current++;
			r.material.color = new Color32 (255, (byte)(255 - 50 * current), (byte)(255 - 21 * current), 255);
		}
		if (going) {
			if (Time.time - t < 3) {
				if (Input.GetKeyDown (KeyCode.Keypad1)|| Input.GetKeyDown(KeyCode.Alpha1)) {
					current++;
					r.material.color = new Color32 (255, (byte)(255 - 50 * current), (byte)(255 - 21 * current), 255);
				}
			} else {
				SceneManager.LoadScene ("Level6");
			}
		}
		if (current == 3) {
			Invoke ("LoadScene", 1);
		}
	}
	void LoadScene(){
		SceneManager.LoadScene ("Level7");
	}

	void OnGUI(){
		GUI.Label (new Rect (0, 0, 100, 20), "Keyboard", guiStyle);
		guiStyle2.fontSize = 100; //change the font size
		//guiStyle.font = myfont;
		guiStyle2.normal.textColor = new Color32(255,105,192,255);
		guiStyle2.alignment = TextAnchor.MiddleCenter;
		GUI.Label (new Rect (150, 150, 100, 20), "HELP ME", guiStyle2);
	}
}
