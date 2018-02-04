using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour {
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
		if (Input.GetMouseButtonDown(0))
		{
			onTap();
		}
	}
	void onTap(){
		Debug.Log ("Tap");
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
		RaycastHit2D hit = Physics2D.Raycast(mousePos2D,Vector2.zero);
		if (hit.collider != null) {
			if (current == 0 && hit.collider.gameObject.name == "purple") {
				current++;
				Destroy (hit.collider.gameObject);
				r.material.color = new Color32 (0, 149, 255, 255);
			} else if (current == 1 && hit.collider.gameObject.name == "blue") {
				current++;
				Destroy (hit.collider.gameObject);
				r.material.color = new Color32 (0, 255, 76, 255);
			} else if (current == 2 && hit.collider.gameObject.name == "green") {
				current++;
				Destroy (hit.collider.gameObject);
				r.material.color = new Color32 (241, 255, 6, 255);
			} else if (current == 3 && hit.collider.gameObject.name == "yellow") {
				current++;
				Destroy (hit.collider.gameObject);
				r.material.color = new Color32 (255, 128, 0, 255);
			} else if (current == 4 && hit.collider.gameObject.name == "orange") {
				current++;
				Destroy (hit.collider.gameObject);
				r.material.color = new Color32 (255, 0, 0, 255);
			} else if (current == 5 && hit.collider.gameObject.name == "red") {
				current++;
				Destroy (hit.collider.gameObject);
				r.material.color = new Color32 (255, 105, 192, 255);
				Invoke ("LoadScene", 1);
			} else {
				SceneManager.LoadScene ("Level2");
			}
		} else {
			SceneManager.LoadScene ("Level2");
		}
	}
	void LoadScene(){
		SceneManager.LoadScene ("Level3");
	}
	void OnGUI(){
		GUI.Label (new Rect (0, 0, 100, 20), "Mouse", guiStyle);
	}

}
