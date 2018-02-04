using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level1 : MonoBehaviour {
	int count = 0;
	private GUIStyle guiStyle = new GUIStyle();

	// Use this for initialization
	GameObject white;
	void Start () {
		white = GameObject.Find ("white");
	 	white.GetComponent<SpriteRenderer> ().material.color = new Color32 (255, 255, 255, 255);
		guiStyle.normal.textColor = Color.black;

	}
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
		if (hit.collider != null) {
			Destroy (hit.collider.gameObject);
			count++;
			if (count == 1) {
				Debug.Log ("1");
				white.GetComponent<SpriteRenderer> ().material.color = new Color32 (255, 205, 235, 255);
			} else if (count == 2) {
				white.GetComponent<SpriteRenderer> ().material.color = new Color32 (255, 155, 215, 255);
			} else if (count == 3) {
				white.GetComponent<SpriteRenderer> ().material.color = new Color32 (255, 105, 192, 255);
				Invoke ("LoadScene", 1);
			}
		}

	}
	void LoadScene(){
		
		SceneManager.LoadScene ("Level2");
	}
	// Update is called once per frame
	void OnGUI(){
		GUI.Label (new Rect (0, 0, 100, 20), "Mouse", guiStyle);

	}
}
