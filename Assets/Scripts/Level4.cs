using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4 : MonoBehaviour {
	SpriteRenderer r;
	float t;
	bool ready;
	private GUIStyle guiStyle = new GUIStyle();

	// Use this for initialization
	void Start () {
		r = GameObject.Find("white").GetComponent<SpriteRenderer>();
		r.material.color = new Color32 (255, 255, 255, 255);
		guiStyle.normal.textColor = Color.black;
		guiStyle.fontSize = 35;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("tap");
			Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Vector2 mousePos2D = new Vector2 (mousePos.x, mousePos.y);
			RaycastHit2D hit = Physics2D.Raycast (mousePos2D, Vector2.zero);
			if (hit.collider != null && hit.collider.gameObject.name == "pink") {
				//Debug.Log ("hit");
				t = Time.time;
				ready = true;
			}
		}
		if (ready) {
			//Debug.Log ("going");
			Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Vector2 mousePos2D = new Vector2 (mousePos.x, mousePos.y);
			RaycastHit2D hit = Physics2D.Raycast (mousePos2D, Vector2.zero);
			//if (Input.GetMouseButton (0) && hit.collider!=null && hit.collider.gameObject.name == "pink" && Time.time - t < 4.0) {
			if (Input.GetMouseButton (0) && Time.time - t < 4.0) {
				mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				mousePos2D = new Vector2 (mousePos.x, mousePos.y);
				hit = Physics2D.Raycast (mousePos2D, Vector2.zero);
				r.material.color = new Color32 (255, (byte)(255 - (37.5 * (Time.time - t))), (byte)(255 - (20.75 * (Time.time - t))), 255);
				/*if (Time.time - t> 0.2f) {
					r.material.color = new Color32 (255, (byte)(255-(41.6*(Time.time-t-0.2f))), (byte)(255-(17.5*(Time.time-t-0.2f))), 255);
				}*/
			} else if (Time.time - t >= 4.0) {
				Debug.Log ("done");
				ready = false;
				Invoke ("LoadScene", 1);
			} else {
				Debug.Log ("false");
				ready = false;
				r.material.color = new Color32 (255, 255, 255, 255);
			}
			}
	}

	void LoadScene(){
		SceneManager.LoadScene ("Level5");
	}
	void OnGUI(){
		GUI.Label (new Rect (0, 0, 100, 20), "Mouse", guiStyle);

	}

}
