using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level9 : MonoBehaviour {
	SpriteRenderer r;
	private GUIStyle guiStyle = new GUIStyle();
	float t;
	//Rigidbody2D m;
	// Use this for initialization
	void Start () {
		r = GameObject.Find("white").GetComponent<SpriteRenderer>();
		r.material.color = new Color32 (255, 255, 255, 255);
		guiStyle.normal.textColor = Color.black;
		t = Time.time;
		//Debug.Log (t);
		Invoke ("verticalMove", 5);
		Invoke ("horizontalMove", 0.1f);
		//m = GameObject.Find ("main").GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			GameObject.Find ("main").transform.Rotate(new Vector3(0,0,2));
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			GameObject.Find ("main").transform.Rotate(new Vector3(0,0,-2));
		}
		if (Time.time-t < 10)
			r.material.color = new Color32 (255, (byte)(255 - 15 * (Time.time-t)), (byte)(255 - 6.3 * (Time.time-t)), 255);
		else {
			Invoke ("LoadScene", 1);
		}
	}
	void LoadScene(){
		SceneManager.LoadScene ("EndGame");
	}

	void verticalMove(){
		GameObject.Find ("down").GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -5);
		GameObject.Find ("up").GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 5);
	}
	void horizontalMove(){
		GameObject.Find ("right1").GetComponent<Rigidbody2D> ().velocity = new Vector2 (5, 0);
		GameObject.Find ("right2").GetComponent<Rigidbody2D> ().velocity = new Vector2 (5, 0);
	}
	void OnGUI(){
		GUI.Label (new Rect (0, 0, 100, 20), "Keyboard", guiStyle);

	}
}
