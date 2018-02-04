using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level9main : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}

	void OnTriggerEnter2D(Collider2D col){
		Destroy (col.gameObject);
		Invoke ("reload", 0.3f);
	}
	void reload(){
		SceneManager.LoadScene ("Level9");
	}
	// Update is called once per frame
	void Update () {
		
	}
}
