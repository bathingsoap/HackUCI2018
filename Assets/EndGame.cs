using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {
	private GUIStyle guiStyle = new GUIStyle();
	private GUIStyle guiStyle2 = new GUIStyle();
	// Use this for initialization
	void Start () {
		guiStyle2.normal.textColor = Color.black;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnGUI(){
		guiStyle2.fontSize = 75; //change the font size
		guiStyle2.normal.textColor = new Color32(255,105,192,255);
		guiStyle2.alignment = TextAnchor.MiddleCenter;
		GUI.Label (new Rect (0, 0, 700, 250), "That's all for now...", guiStyle2);
	}
}
