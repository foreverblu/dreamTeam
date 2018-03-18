using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Weapon") {
			this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
			this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
		}
			
	}
}
