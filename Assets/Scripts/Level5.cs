using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level5 : MonoBehaviour {
	SpriteRenderer r;
	int current = 0;
	Vector3 mousePos;
	Vector2 mousePos2D;
	RaycastHit2D hit;
	float t;
	bool going;
	public GameObject black;
	float timelimit;
	private GUIStyle guiStyle = new GUIStyle();

	// Use this for initialization
	void Start () {
		r = GameObject.Find("white").GetComponent<SpriteRenderer>();
		r.material.color = new Color32 (255, 255, 255, 255);
		Instantiate (black, new Vector2 (Random.Range(-8,8), Random.Range(-3,3)),Quaternion.identity);
		going = false;
		t = 0;
		timelimit = 1f;
		guiStyle.normal.textColor = Color.black;

	}

	// Update is called once per frame
	void Update () {
		mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		mousePos2D = new Vector2(mousePos.x, mousePos.y);
		hit = Physics2D.Raycast(mousePos2D,Vector2.zero);
		if (going && Time.time - t > timelimit) {
			SceneManager.LoadScene ("Level5");
		}

		if (hit.collider != null) {
			if (hit.collider.gameObject.name == "black" || hit.collider.gameObject.name == "black(Clone)") {
				going = true;
				t = Time.time;
				black.transform.localScale -= new Vector3 (0.1f, 0.1f, 0);
				Instantiate (black, new Vector2 (Random.Range (-8, 8), Random.Range (-3, 3)), Quaternion.identity);
				current++;
				r.material.color = new Color32 (255, (byte)(255 - 17 * current), (byte)(255 - 7 * current), 255);
				Destroy (hit.collider.gameObject);
			}
			if (current == 10) {
				Invoke ("LoadScene", 1);
			}

		}
	}
	void LoadScene(){
		SceneManager.LoadScene ("Level6");
	}
	void OnGUI(){
		GUI.Label (new Rect (0, 0, 100, 20), "Mouse", guiStyle);

	}

}
