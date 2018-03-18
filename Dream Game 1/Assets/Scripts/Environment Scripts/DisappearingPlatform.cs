using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingPlatform : MonoBehaviour {

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Player")
		{
			Debug.Log ("Done");
			this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
			this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
			StartCoroutine (appear ());
		}
	}
	IEnumerator appear() {
		yield return new WaitForSeconds (5);
		this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
		this.gameObject.GetComponent<BoxCollider2D>().enabled = true;
	}
}
