using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level7 : MonoBehaviour {
	SpriteRenderer r;
	private GUIStyle guiStyle = new GUIStyle();
	bool dragging = false;

	// Use this for initialization
	void Start () {
		//r = GameObject.Find("background").GetComponent<SpriteRenderer>();
		guiStyle.normal.textColor = Color.black;
		guiStyle.fontSize = 35;
		foreach (SpriteRenderer c in GameObject.Find("surrounding").GetComponentsInChildren<SpriteRenderer>()) {
			//c.material.color = new Color32 (0, 255, 255, 255);
			c.material.color = new Color32 (255, 255, 255, 255);
		}
		//Physics2D.IgnoreCollision (GameObject.Find ("whitecircle").GetComponent<Collider2D> (), GameObject.Find ("blackcircle").GetComponent<Collider2D> ());

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Vector2 mousePos2D = new Vector2 (mousePos.x, mousePos.y);
			RaycastHit2D hit = Physics2D.Raycast (mousePos2D, Vector2.zero);
			if (hit.collider != null && hit.collider.gameObject.name == "block") {
				dragging = true;
			}
		}
		if (dragging == true && Input.GetMouseButton (0)) {
			Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			GameObject.Find("block").gameObject.transform.position = new Vector3(mousePos.x, mousePos.y, 0);
		}
		if (Input.GetMouseButtonUp (0)) {
			dragging = false;
		}

	}
	void OnGUI(){
		GUI.Label (new Rect (0, 0, 100, 20), "Mouse", guiStyle);
	}
}
