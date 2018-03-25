using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {
	Rigidbody2D test;
	Vector2 right;
	bool flip;
	// Use this for initialization
	void Start () {
		test = GetComponent<Rigidbody2D> ();
		flip = true;
		test.AddForce (new Vector2 (100, 0));
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (flip) {
			flip = false;
			StartCoroutine (moveForward());
		}
		
	}

	IEnumerator moveForward() {
		test.AddForce (new Vector2 (-200, 0));
		yield return new WaitForSeconds (5);
		test.AddForce (new Vector2(200, 0));
		yield return new WaitForSeconds (5);
		flip = true;
	}
}
