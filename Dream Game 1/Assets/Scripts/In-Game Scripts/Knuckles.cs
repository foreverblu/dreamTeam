using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knuckles : MonoBehaviour {
	//damage of the arrow
	public float damageValue = 15.0f;

	//game objects in the game
	public GameObject GM;
	public GameObject RangePlayer;

	// Use this for initialization
	void Start () {
		GM = GameObject.Find("GameManager");
		RangePlayer = GameObject.Find("RangePlayer");
		this.GetComponent<Rigidbody2D>().AddForce(RangePlayer.GetComponent<RangePlayerControl>().getDirection() * 500);
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = RangePlayer.transform.position + RangePlayer.GetComponent<RangePlayerControl>().getDirection();
		
	}
	void FixedUpdate()
	{
		Destroy(gameObject, 1.0f);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name != "RangePlayer")
		{
			GM.SendMessage(other.gameObject.name + "Damaged", damageValue);
			Destroy(gameObject);
		}
	}
}
