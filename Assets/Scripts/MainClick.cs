using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainClick : MonoBehaviour {
	SpriteRenderer r;
	private GUIStyle guiStyle = new GUIStyle();
	// Use this for initialization
	void Start () {
		
		r = GameObject.Find("white").GetComponent<SpriteRenderer>();
		r.material.color = new Color32 (255, 255, 255, 255);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			onTap();
		}
	}

	void onTap(){
		Debug.Log ("Tap");
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
		//Ray raycast = new Vector2 (Camera.main.ScreenToWorldPoint(Input.mousePosition));
		RaycastHit2D hit = Physics2D.Raycast(mousePos2D,Vector2.zero);
		if (hit.collider.gameObject.name == "Start") {
			Debug.Log("Start");
			r.material.color = new Color32 (255, 105, 192, 255);
			Invoke ("LoadScene", 1);
			}

	}

	void LoadScene(){
		SceneManager.LoadScene ("Level1");
	}
	void OnGUI(){
		guiStyle.fontSize = 60; //change the font size
		guiStyle.normal.textColor = Color.white;
		guiStyle.alignment = TextAnchor.MiddleCenter;
		GUI.Label (new Rect (600, 330, 80, 60), "PINK", guiStyle);
	}
}
